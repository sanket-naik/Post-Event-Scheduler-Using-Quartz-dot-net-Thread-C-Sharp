

namespace Quartz
{
    class Jobs
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Task { get; set; }
        public string Date { get; set; }

        /// <summary>
        /// Date formate Day/Month
        /// </summary>
        /// <returns>Job</returns>
        public static Jobs[] GetAllJobs()
        {
            Jobs[] job = new Jobs[4];

            job[0] = new Jobs { Id = 1, Email = "Abhi.naik@outlook.com", Task = "Get the work done", Date = "13-02" };
            job[1] = new Jobs { Id = 2, Email = "110san@gmail.com", Task = "Complete on time", Date = "20-02" };
            job[2] = new Jobs { Id = 3, Email = "abhin@yahoo.com", Task = "Do the testing", Date = "13-02" };
            job[3] = new Jobs { Id = 4, Email = "John@cner.com", Task = "Manage the server", Date = "14-02" };

            return job;
        }
    }
}
