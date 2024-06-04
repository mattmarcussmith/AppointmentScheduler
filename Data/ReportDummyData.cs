using System;
using System.Collections.Generic;
using System.Linq;

namespace C969MatthewSmith.Forms.Report
{
    public class ReportDummyData
    {
        public static Dictionary<string, Dictionary<string, List<(string, int)>>> GetTypeMonthData()
        {
            Dictionary<string, Dictionary<string, List<(string, int)>>> data = new Dictionary<string, Dictionary<string, List<(string, int)>>>();

            Dictionary<string, List<(string, int)>> januaryData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ethan Johnson", 7), ("Olivia Martinez", 7), ("Sophia Morrison", 7), ("Liam Parker", 7), ("Ava Taylor", 7) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 10), ("Emma Wilson", 9), ("Mason Lopez", 8), ("Ella Martinez", 7), ("Noah Anderson", 6) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 9), ("Ava Hernandez", 8), ("Oliver Smith", 7), ("Isabella Brown", 6), ("Lucas White", 5) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 10), ("Lucas Roberts", 9), ("Harper Perez", 8), ("Liam Johnson", 7), ("Ella Davis", 6) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 12), ("Alexander Garcia", 10), ("Madison Martinez", 9), ("Emma White", 8), ("Noah Wilson", 7) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 33), ("William Adams", 22), ("Evelyn Nelson", 19), ("Liam Thomas", 16), ("Olivia Clark", 13) } },
    { "Other", new List<(string, int)> { ("Other", 8), ("Other", 7), ("Other", 6), ("Other", 5), ("Other", 4) } }
};
            data.Add("January", januaryData);

            Dictionary<string, List<(string, int)>> februaryData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ethan Johnson", 8), ("Olivia Martinez", 8), ("Sophia Morrison", 8), ("Liam Parker", 8), ("Ava Taylor", 8) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 11), ("Emma Wilson", 10), ("Mason Lopez", 9), ("Ella Martinez", 8), ("Noah Anderson", 7) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 10), ("Ava Hernandez", 9), ("Oliver Smith", 8), ("Isabella Brown", 7), ("Lucas White", 6) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 11), ("Lucas Roberts", 10), ("Harper Perez", 9), ("Liam Johnson", 8), ("Ella Davis", 7) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 13), ("Alexander Garcia", 11), ("Madison Martinez", 10), ("Emma White", 9), ("Noah Wilson", 8) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 36), ("William Adams", 24), ("Evelyn Nelson", 21), ("Liam Thomas", 18), ("Olivia Clark", 15) } },
    { "Other", new List<(string, int)> { ("Other", 9), ("Other", 8), ("Other", 7), ("Other", 6), ("Other", 5) } }
};
            data.Add("February", februaryData);

            Dictionary<string, List<(string, int)>> marchData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ethan Johnson", 9), ("Olivia Martinez", 9), ("Sophia Morrison", 9), ("Liam Parker", 9), ("Ava Taylor", 9) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 12), ("Emma Wilson", 11), ("Mason Lopez", 10), ("Ella Martinez", 9), ("Noah Anderson", 8) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 11), ("Ava Hernandez", 10), ("Oliver Smith", 9), ("Isabella Brown", 8), ("Lucas White", 7) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 12), ("Lucas Roberts", 11), ("Harper Perez", 10), ("Liam Johnson", 9), ("Ella Davis", 8) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 14), ("Alexander Garcia", 12), ("Madison Martinez", 11), ("Emma White", 10), ("Noah Wilson", 9) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 39), ("William Adams", 26), ("Evelyn Nelson", 23), ("Liam Thomas", 20), ("Olivia Clark", 17) } },
    { "Other", new List<(string, int)> { ("Other", 10), ("Other", 9), ("Other", 8), ("Other", 7), ("Other", 6) } }
};
            data.Add("March", marchData);


            Dictionary<string, List<(string, int)>> aprilData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Alice Jackson", 1), ("Jane Martin", 1), ("Bob Morrison", 1) } },
    { "Follow Up", new List<(string, int)> { ("Corey Fisher", 3) } },
    { "Emergency", new List<(string, int)> { ("Mike Taylor", 2) } },
    { "Routine", new List<(string, int)> { ("Seth Parker", 3) } },
    { "Preventative Care", new List<(string, int)> { ("Adam Andrews", 5) } },
    { "Wellness Visit", new List<(string, int)> { ("John Brown", 1) } },
    { "Other", new List<(string, int)> { ("Other", 1) } }
};
            data.Add("April", aprilData);

            Dictionary<string, List<(string, int)>> mayData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ella Jackson", 1), ("Liam Martin", 1), ("Olivia Morrison", 1) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 3) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 1) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 1) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 5) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 2) } },
    { "Other", new List<(string, int)> { ("Other", 13) } }
};
            data.Add("May", mayData);
            Dictionary<string, List<(string, int)>> juneData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ella Jackson", 1), ("Liam Martin", 1), ("Olivia Morrison", 1), ("Sophia Parker", 1), ("Ethan Taylor", 1) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 3), ("Emma Wilson", 2), ("Mason Lopez", 1) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 2), ("Ava Hernandez", 1) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 3), ("Lucas Roberts", 2), ("Harper Perez", 1) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 5), ("Alexander Garcia", 3), ("Madison Martinez", 2) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 12), ("William Adams", 8), ("Evelyn Nelson", 6) } },
    { "Other", new List<(string, int)> { ("Other", 1), ("Other", 1) } }
};
            data.Add("June", juneData);

            Dictionary<string, List<(string, int)>> julyData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Liam Jackson", 2), ("Olivia Martin", 2), ("Sophia Morrison", 2), ("Ethan Parker", 2), ("Ava Taylor", 2) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 4), ("Emma Wilson", 3), ("Mason Lopez", 2), ("Ella Martinez", 1) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 3), ("Ava Hernandez", 2), ("Oliver Smith", 1) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 4), ("Lucas Roberts", 3), ("Harper Perez", 2), ("Liam Johnson", 1) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 6), ("Alexander Garcia", 4), ("Madison Martinez", 3), ("Emma White", 2) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 15), ("William Adams", 10), ("Evelyn Nelson", 8), ("Liam Thomas", 5) } },
    { "Other", new List<(string, int)> { ("Other", 2), ("Other", 2), ("Other", 1) } }
};
            data.Add("July", julyData);
            Dictionary<string, List<(string, int)>> septemberData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ethan Johnson", 3), ("Olivia Martinez", 3), ("Sophia Morrison", 3), ("Liam Parker", 3), ("Ava Taylor", 3) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 6), ("Emma Wilson", 5), ("Mason Lopez", 4), ("Ella Martinez", 3), ("Noah Anderson", 2) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 5), ("Ava Hernandez", 4), ("Oliver Smith", 3), ("Isabella Brown", 2), ("Lucas White", 1) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 6), ("Lucas Roberts", 5), ("Harper Perez", 4), ("Liam Johnson", 3), ("Ella Davis", 2) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 8), ("Alexander Garcia", 6), ("Madison Martinez", 5), ("Emma White", 4), ("Noah Wilson", 3) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 21), ("William Adams", 14), ("Evelyn Nelson", 11), ("Liam Thomas", 8), ("Olivia Clark", 5) } },
    { "Other", new List<(string, int)> { ("Other", 4), ("Other", 3), ("Other", 2), ("Other", 1), ("Other", 1) } }
};
            data.Add("September", septemberData);

            Dictionary<string, List<(string, int)>> octoberData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ethan Johnson", 4), ("Olivia Martinez", 4), ("Sophia Morrison", 4), ("Liam Parker", 4), ("Ava Taylor", 4) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 7), ("Emma Wilson", 6), ("Mason Lopez", 5), ("Ella Martinez", 4), ("Noah Anderson", 3) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 6), ("Ava Hernandez", 5), ("Oliver Smith", 4), ("Isabella Brown", 3), ("Lucas White", 2) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 7), ("Lucas Roberts", 6), ("Harper Perez", 5), ("Liam Johnson", 4), ("Ella Davis", 3) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 9), ("Alexander Garcia", 7), ("Madison Martinez", 6), ("Emma White", 5), ("Noah Wilson", 4) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 24), ("William Adams", 16), ("Evelyn Nelson", 13), ("Liam Thomas", 10), ("Olivia Clark", 7) } },
    { "Other", new List<(string, int)> { ("Other", 5), ("Other", 4), ("Other", 3), ("Other", 2), ("Other", 1) } }
};
            data.Add("October", octoberData);

          
            Dictionary<string, List<(string, int)>> novemberData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ethan Johnson", 5), ("Olivia Martinez", 5), ("Sophia Morrison", 5), ("Liam Parker", 5), ("Ava Taylor", 5) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 8), ("Emma Wilson", 7), ("Mason Lopez", 6), ("Ella Martinez", 5), ("Noah Anderson", 4) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 7), ("Ava Hernandez", 6), ("Oliver Smith", 5), ("Isabella Brown", 4), ("Lucas White", 3) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 8), ("Lucas Roberts", 7), ("Harper Perez", 6), ("Liam Johnson", 5), ("Ella Davis", 4) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 10), ("Alexander Garcia", 8), ("Madison Martinez", 7), ("Emma White", 6), ("Noah Wilson", 5) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 27), ("William Adams", 18), ("Evelyn Nelson", 15), ("Liam Thomas", 12), ("Olivia Clark", 9) } },
    { "Other", new List<(string, int)> { ("Other", 6), ("Other", 5), ("Other", 4), ("Other", 3), ("Other", 2) } }
};
            data.Add("November", novemberData);

            Dictionary<string, List<(string, int)>> decemberData = new Dictionary<string, List<(string, int)>>
{
    { "Initial Consultation", new List<(string, int)> { ("Ethan Johnson", 6), ("Olivia Martinez", 6), ("Sophia Morrison", 6), ("Liam Parker", 6), ("Ava Taylor", 6) } },
    { "Follow Up", new List<(string, int)> { ("Aiden Fisher", 9), ("Emma Wilson", 8), ("Mason Lopez", 7), ("Ella Martinez", 6), ("Noah Anderson", 5) } },
    { "Emergency", new List<(string, int)> { ("Noah Taylor", 8), ("Ava Hernandez", 7), ("Oliver Smith", 6), ("Isabella Brown", 5), ("Lucas White", 4) } },
    { "Routine", new List<(string, int)> { ("Mia Parker", 9), ("Lucas Roberts", 8), ("Harper Perez", 7), ("Liam Johnson", 6), ("Ella Davis", 5) } },
    { "Preventative Care", new List<(string, int)> { ("Isabella Andrews", 11), ("Alexander Garcia", 9), ("Madison Martinez", 8), ("Emma White", 7), ("Noah Wilson", 6) } },
    { "Wellness Visit", new List<(string, int)> { ("Sophia Brown", 30), ("William Adams", 20), ("Evelyn Nelson", 17), ("Liam Thomas", 14), ("Olivia Clark", 11) } },
    { "Other", new List<(string, int)> { ("Other", 7), ("Other", 6), ("Other", 5), ("Other", 4), ("Other", 3) } }
};
            data.Add("December", decemberData);

            return data;
        }

        public static List<string> GetAppointmentTypes()
        {
            return new List<string>
            {
                "Initial Consultation",
                "Follow Up",
                "Emergency",
                "Routine",
                "Preventative Care",
                "Wellness Visit",
                "Other"
            };
        }

        public static List<string> GetMonths()
        {
            return new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
        }
    }
}
