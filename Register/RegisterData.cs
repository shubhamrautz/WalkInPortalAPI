using System.Data;
using WalkInPortalAPI.Helper;
using Dapper;
using WalkInPortalAPI.Models;
using System.Transactions;

namespace WalkInPortalAPI.Register
{
    public class RegisterData : IRegisterData
    {

        private readonly DatabaseConnection _DbConnection;
        public RegisterData(DatabaseConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }

        public async Task<dynamic> Register(CreateUser user)
        {
            DynamicParameters userParameters = new DynamicParameters();
            userParameters.Add("email_id", user.Email);
            userParameters.Add("password", user.Password);
            userParameters.Add("profile_picture", user.ProfilePicture);
            userParameters.Add("firstname", user.Firstname);
            userParameters.Add("lastname", user.Lastname);
            userParameters.Add("phone_no", user.PhoneNo);
            userParameters.Add("resume_link", user.ResumeLink);
            userParameters.Add("portfolio_link", user.PortfolioLink);
            userParameters.Add("referal", user.Referal);
            userParameters.Add("send_mail", user.SendMail);
            userParameters.Add("previously_applied_role", user.PreviouslyAppliedRole);
            userParameters.Add("applicant_type_id", user.ApplicantTypeId);

            DynamicParameters educationParameters = new DynamicParameters();
            educationParameters.Add("passing_year", user.PassingYear);
            educationParameters.Add("percentage", user.Percentage);
            educationParameters.Add("college_location", user.CollegeLocation);
            educationParameters.Add("college_id", user.CollegeId);
            educationParameters.Add("stream_id", user.StreamId);
            educationParameters.Add("qualification_id", user.QualificationId);

            DynamicParameters experienceParameters = new DynamicParameters();
            experienceParameters.Add("years", user.Years);
            experienceParameters.Add("current_ctc", user.CurrentCtc);
            experienceParameters.Add("expected_ctc", user.ExpectedCtc);
            experienceParameters.Add("notice_period_end", user.NoticePeriodEnd);
            experienceParameters.Add("notice_duration", user.NoticeDuration);

            using TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

            using (IDbConnection conn = _DbConnection.CreateConn())
            {
                userParameters.AddDynamicParams(educationParameters);

                int UserId = await conn.QuerySingleAsync<int>("createUser", userParameters, commandType: CommandType.StoredProcedure);

                //string prefferedJobRole="create temporary table _prefferedJobRole (id int);";

                //string insert = "insert into _prefferedJobRole (id) values " + string.Join(",",user.JobRoleId.Select(id => $"({id})"));

                if (UserId == -1)
                {
                    conn.Close();
                    return "Email ID Already Exists";
                }

                if (user.JobRoleId != null)
                {
                    DynamicParameters prefferdJobParameters = new DynamicParameters();
                    prefferdJobParameters.Add("user_id", UserId);
                    prefferdJobParameters.Add("job_role_id", user.JobRoleId);
                    await conn.QueryAsync("createPrefferedJob", prefferdJobParameters, commandType: CommandType.StoredProcedure);
                }

                if (user.FamiliarTechnologyId != null)
                {
                    DynamicParameters familiarTechnologyParameters = new DynamicParameters();
                    familiarTechnologyParameters.Add("user_id", UserId);
                    familiarTechnologyParameters.Add("technology_id", user.FamiliarTechnologyId);
                    familiarTechnologyParameters.Add("other_technology", user.OtherTechnology);
                    await conn.QueryAsync("createFamiliarTechnology", familiarTechnologyParameters, commandType: CommandType.StoredProcedure);
                }

                if (user.ApplicantTypeId == 1)
                {
                    scope.Complete();
                    conn.Close();
                    return UserId;
                }

                experienceParameters.Add("user_id", UserId);
                int ExperienceId = await conn.QuerySingleAsync<int>("createExperience", experienceParameters, commandType: CommandType.StoredProcedure);

                if (user.ExpertiseTechnologyId != null)
                {
                    DynamicParameters expertiseTechnologyParameters = new DynamicParameters();
                    expertiseTechnologyParameters.Add("experience_id", ExperienceId);
                    expertiseTechnologyParameters.Add("technology_id", user.ExpertiseTechnologyId);
                    expertiseTechnologyParameters.Add("other_technology", user.OtherExpertiseTechnology);
                    await conn.QueryAsync("createExpertiseTechnology", expertiseTechnologyParameters, commandType: CommandType.StoredProcedure);
                }

                scope.Complete();
                conn.Close();

                return $"Account Created Successfully with user id {UserId}";
            }
        }
    }
}

