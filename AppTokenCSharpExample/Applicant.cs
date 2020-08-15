using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTokenCSharpExample
{
    public class Applicant
    {
        public string id { get; set; }
        public string createdAt { get; set; }
        public string key { get; set; }
        public string clientId { get; set; }
        public string inspectionId { get; set; }
        public string externalUserId { get; set; }
        public Info info { get; set; }
        public Requirediddocs requiredIdDocs { get; set; }
        public Review review { get; set; }
        public string type { get; set; }
    }

    public class Info
    {
    }

    public class Requirediddocs
    {
        public Docset[] docSets { get; set; }
    }

    public class Docset
    {
        public string idDocSetType { get; set; }
        public string[] types { get; set; }
    }

    public class Review
    {
        public bool reprocessing { get; set; }
        public string createDate { get; set; }
        public string reviewStatus { get; set; }
        public int notificationFailureCnt { get; set; }
        public int priority { get; set; }
        public bool autoChecked { get; set; }
    }

}
