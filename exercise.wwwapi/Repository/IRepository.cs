﻿using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface IRepository
    {
        Language AddLanguage (Language language);
        IEnumerable<Language> GetAllLanguages();
        Language GetLanguage(string Name);
        Language UpdateLanguage(string Name, Language language);
        Language DeleteLanguage(string Name);

        Student AddStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(string firstName);
        Student UpdateStudent(string firstName, Student student);
        Student DeleteStudent(string firstName);

        Book AddBook(Book book);
        IEnumerable<Book> GetAllBooks();
        Book GetBook(int id);
        Book UpdateBook(int id, Book book);
        Book DeleteBook(int id);
    }
}
