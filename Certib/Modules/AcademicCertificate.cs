using System;
using Silicon;

namespace Certib.Modules
{
    public class AcademicCertificate
    {
        public int  marks_obtained, max_marks;
        public string certificate_id,department,certificate_date;
        public string full_name, email, university_seat_number, remarks, academic_year, certificatehash;
        public float percentage;

        public AcademicCertificate(int CertificateNo, int Marks1, int Mark2, string FullName, string Email, string Usn, string Remarks, string AcademicYear, string department)
        {
            this.certificate_id = "ANC00853-"+Convert.ToString(CertificateNo);
            this.marks_obtained = Marks1;
            this.max_marks = Mark2;
            this.full_name = FullName;
            this.email = Email;
            this.university_seat_number = Usn;
            this.remarks = Remarks;
            this.academic_year = AcademicYear;
            this.percentage = (Marks1*100 / Mark2);
            this.certificate_date = DateTime.Now.ToString("dd/MM/yyyy");
            this.department = department;
            this.certificatehash = SILICON64.GenerateHash(Convert.ToString(certificate_id) +
                Convert.ToString(marks_obtained) + Convert.ToString(max_marks) + email +
                university_seat_number + remarks + academic_year + Convert.ToString(percentage));
        }
    }
}