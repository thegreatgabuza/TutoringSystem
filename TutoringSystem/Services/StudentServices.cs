using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutoringSystem.Interfaces;
using TutoringSystem.Models;

namespace TutoringSystem.Services
{
        public class StudentService : IStudentService
        {
            public IEnumerable<Student> GetAllStudents()
            {
                // TODO: Implement this method to return all students from the database.
                return new List<Student>();
            }

            public void RegisterStudent(Student student)
            {
                // TODO: Implement this method to register a new student in the database.
            }

            public void SelectModule(int moduleId)
            {
                // TODO: Implement this method to select a module for a student.
            }

            public void BookSession(int tutorId, DateTime startDate, DateTime endDate)
            {
                // TODO: Implement this method to book a tutoring session for a student.
            }

            public void PayBooking(int bookingId)
            {
                // TODO: Implement this method to pay for a tutoring session.
            }

            public IEnumerable<Booking> GetAllBookings()
            {
                // TODO: Implement this method to return all bookings for a student.
                return new List<Booking>();
            }
        }
    }

