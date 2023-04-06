using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Core
{
    public class Controller : IController
    {
        private SubjectRepository subjects;
        private StudentRepository students;
        private UniversityRepository universities;
        private string[] subjectTypes = new string[] { "TechnicalSubject", "EconomicalSubject", "HumanitySubject" };

        public Controller()
        {
            subjects= new SubjectRepository();
            students= new StudentRepository();
            universities= new UniversityRepository();
        }
        public string AddStudent(string firstName, string lastName)
        {
            Student newStudent = new(0, firstName, lastName);
            
            if(newStudent== null)
            {
                return String.Format(OutputMessages.AlreadyAddedStudent,firstName,lastName);
            }

            
            students.AddModel(newStudent);
            return String.Format(OutputMessages.StudentAddedSuccessfully, firstName, lastName, students.GetType().Name);
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            if (!subjectTypes.Contains(subjectType))
            {
                return (String.Format(OutputMessages.SubjectTypeNotSupported, subjectType));
            }

            if (subjects.FindByName(subjectName) != null)
            {
                return (String.Format(OutputMessages.AlreadyAddedStudent, subjectName));
            }

            Subject subject = null;
            if(subjectType == "TechnicalSubject")
            {
                subject = new TechnicalSubject(0, subjectName);
            }
            if (subjectType == "EconomicalSubject")
            {
                subject = new EconomicalSubject(0, subjectName);
            }
            if (subjectType == "HumanitySubject")
            {
                subject = new HumanitySubject(0, subjectName);
            }
            subjects.AddModel(subject);
            return String.Format(OutputMessages.SubjectAddedSuccessfully,subjectType, subjectName, subjects.GetType().Name);

        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if (universities.FindByName(universityName) != null)
            {
                return String.Format(OutputMessages.AlreadyAddedUniversity,universityName);
            }

            List<int> requiredSubjectsAsInts = requiredSubjects.Select(x=>subjects.FindByName(x).Id).ToList();
            University newUniversity = new(0, universityName, category, capacity, requiredSubjectsAsInts);
            universities.AddModel(newUniversity);
            return String.Format(OutputMessages.UniversityAddedSuccessfully, universityName, universities.GetType().Name);
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            IStudent newStudent = students.FindByName(studentName);
            IUniversity newUniversity = universities.FindByName(universityName);

            if (newStudent == null)
            {
                return String.Format(OutputMessages.StudentNotRegitered, newStudent.FirstName, newStudent.LastName);
            }
            if (newUniversity == null)
            {
                return String.Format(OutputMessages.UniversityNotRegitered, newUniversity.Name);
            }

            foreach (var requiredExams in newUniversity.RequiredSubjects)
            {
                if (!newStudent.CoveredExams.Contains(requiredExams))
                {
                    return String.Format(OutputMessages.StudentHasToCoverExams, studentName, universityName);
                }
            }

            if(newStudent.University != null && newStudent.University.Name == universityName)
            {
                return String.Format(OutputMessages.StudentAlreadyJoined, newStudent.FirstName, newStudent.LastName, universityName);
            }

            newStudent.JoinUniversity(newUniversity);
            return String.Format(OutputMessages.StudentSuccessfullyJoined, newStudent.FirstName, newStudent.LastName, universityName);
        }

        public string TakeExam(int studentId, int subjectId)
        {
            IStudent newStudent = students.FindById(studentId);
            if (newStudent == null)
            {
                return String.Format(OutputMessages.InvalidStudentId);

            }
            ISubject newSubject = subjects.FindById(subjectId);
            if (newSubject == null)
            {
                return String.Format(OutputMessages.InvalidSubjectId);
            }

            if(newStudent.CoveredExams.Contains(subjectId))
            {
                return String.Format(OutputMessages.StudentAlreadyCoveredThatExam, newStudent.FirstName, newStudent.LastName, newSubject.Name);
            }

            newStudent.CoverExam(newSubject);
            return String.Format(OutputMessages.StudentSuccessfullyCoveredExam, newStudent.FirstName, newStudent.LastName, newSubject.Name);

        }

        public string UniversityReport(int universityId)
        {
            IUniversity university = universities.FindById(universityId);

            StringBuilder sb = new();
            int studentsCount = StudentsCount(university);
            sb.AppendLine($"*** {university.Name} ***");
            sb.AppendLine($"Profile: {university.Category}");
            sb.AppendLine($"Students admitted: {studentsCount}");
            sb.AppendLine($"University vacancy: {university.Capacity- studentsCount}");

            return sb.ToString().Trim();
        }

        private int StudentsCount(IUniversity university)
        {
            int counter = 0;
            foreach (var student in students.Models)
            {
                if (student.University?.Id == university.Id)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}