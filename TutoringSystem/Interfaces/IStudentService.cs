using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutoringSystem.Models;

namespace TutoringSystem.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        void RegisterStudent(Student student);
        void SelectModule(int moduleId);
        void BookSession(int tutorId, DateTime startDate, DateTime endDate);
        void PayBooking(int bookingId);
        IEnumerable<Booking> GetAllBookings();
    }
}
