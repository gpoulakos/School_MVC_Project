namespace Assignment2._1.Database.Migrations
{
    using Assignment2._1.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2._1.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment2._1.Database.MyDatabase context)
        {
            // ============================= Seed Students ============================= //

            Student s1 = new Student() { FirstName = "Xenofontas", LastName = "Vlachogiannis", DateOfBirth = new DateTime(1987, 5, 21), TuitionFees = 2150 };
            Student s2 = new Student() { FirstName = "Georgios", LastName = "Poulakos", DateOfBirth = new DateTime(1986, 10, 21), TuitionFees = 2150 };
            Student s3 = new Student() { FirstName = "Eleni", LastName = "Parisi", DateOfBirth = new DateTime(1988, 8, 19), TuitionFees = 2150 };
            Student s4 = new Student() { FirstName = "Stathis", LastName = "Kanellis", DateOfBirth = new DateTime(1981, 11, 12), TuitionFees = 2150 };
            Student s5 = new Student() { FirstName = "Evangelos", LastName = "Koutsogiorgos", DateOfBirth = new DateTime(1987, 9, 21), TuitionFees = 2150 };

            Student s6 = new Student() { FirstName = "Zacharias", LastName = "Drimiskianakis", DateOfBirth = new DateTime(1986, 12, 21), TuitionFees = 2150 };
            Student s7 = new Student() { FirstName = "Vasileios", LastName = "Theodoropoulos", DateOfBirth = new DateTime(1988, 5, 4), TuitionFees = 2150 };
            Student s8 = new Student() { FirstName = "Themistoklis", LastName = "Papageprgiou", DateOfBirth = new DateTime(1990, 3, 2), TuitionFees = 2250 };
            Student s9 = new Student() { FirstName = "Thanos", LastName = "Katrakis", DateOfBirth = new DateTime(1986, 7, 30), TuitionFees = 2150 };
            Student s10 = new Student() { FirstName = "Thanos", LastName = "Christidis", DateOfBirth = new DateTime(1989, 11, 21), TuitionFees = 2350 };

            Student s11 = new Student() { FirstName = "Panagiotis", LastName = "Rizos", DateOfBirth = new DateTime(1993, 3, 18), TuitionFees = 2150 };
            Student s12 = new Student() { FirstName = "Adam", LastName = "Zotiadis", DateOfBirth = new DateTime(1994, 2, 21), TuitionFees = 2150 };
            Student s13 = new Student() { FirstName = "Konstantinos", LastName = "Argyropoulos", DateOfBirth = new DateTime(1991, 6, 4), TuitionFees = 2250 };
            Student s14 = new Student() { FirstName = "Karol", LastName = "Koniewicz", DateOfBirth = new DateTime(1990, 4, 12), TuitionFees = 2150 };
            Student s15 = new Student() { FirstName = "Ioannis", LastName = "Manthos", DateOfBirth = new DateTime(1983, 5, 12), TuitionFees = 2350 };

            Student s16 = new Student() { FirstName = "Ioannis", LastName = "Elefsiniotis", DateOfBirth = new DateTime(1979, 8, 22), TuitionFees = 2150 };
            Student s17 = new Student() { FirstName = "Georgios", LastName = "Panagoulias", DateOfBirth = new DateTime(1986, 9, 29), TuitionFees = 2150 };
            Student s18 = new Student() { FirstName = "Dionysios", LastName = "Pilikas", DateOfBirth = new DateTime(1984, 9, 29), TuitionFees = 2250 };
            Student s19 = new Student() { FirstName = "Christos", LastName = "Vasilakis", DateOfBirth = new DateTime(1989, 4, 1), TuitionFees = 2150 };
            Student s20 = new Student() { FirstName = "Athanasios", LastName = "Kontodimas", DateOfBirth = new DateTime(1986, 10, 3), TuitionFees = 2350 };

            Student s21 = new Student() { FirstName = "Alexandros", LastName = "Perikleous", DateOfBirth = new DateTime(1988, 6, 25), TuitionFees = 2150 };
            Student s22 = new Student() { FirstName = "Albi", LastName = "Alikaj", DateOfBirth = new DateTime(1988, 1, 9), TuitionFees = 2150 };
            Student s23 = new Student() { FirstName = "Panagiotis", LastName = "Bourbopoulos", DateOfBirth = new DateTime(1986, 7, 12), TuitionFees = 2250 };
            Student s24 = new Student() { FirstName = "Angelos", LastName = "Papadopoulos", DateOfBirth = new DateTime(1986, 1, 30), TuitionFees = 2150 };
            Student s25 = new Student() { FirstName = "Lefteris", LastName = "Litinas", DateOfBirth = new DateTime(1996, 12, 15), TuitionFees = 2350 };

            Student s26 = new Student() { FirstName = "Ilias", LastName = "Karaplis", DateOfBirth = new DateTime(1998, 3, 26), TuitionFees = 2150 };
            Student s27 = new Student() { FirstName = "Alexandros", LastName = "Makris", DateOfBirth = new DateTime(1985, 12, 30), TuitionFees = 2150 };
            Student s28 = new Student() { FirstName = "Dionysis", LastName = "Kanellopoulos", DateOfBirth = new DateTime(1986, 3, 17), TuitionFees = 2250 };
            Student s29 = new Student() { FirstName = "Markos", LastName = "Benveniste", DateOfBirth = new DateTime(1986, 8, 26), TuitionFees = 2150 };
            Student s30 = new Student() { FirstName = "Nikos", LastName = "Leonidakis", DateOfBirth = new DateTime(1978, 11, 13), TuitionFees = 2350 };

            // ============================= Seed Trainers ============================= //

            Trainer t1 = new Trainer() { FirstName = "Hector", LastName = "Gatsos", Subject = "C Sharp" };
            Trainer t2 = new Trainer() { FirstName = "Kostas", LastName = "Stroggylos", Subject = "Database" };
            Trainer t3 = new Trainer() { FirstName = "Kostantinos", LastName = "Minaidis", Subject = "Javascript" };
            Trainer t4 = new Trainer() { FirstName = "George", LastName = "Pasparakis", Subject = "UI/UX - Usability" };
            Trainer t5 = new Trainer() { FirstName = "Vasilis", LastName = "Tzelepopoulos", Subject = "HTML / CSS" };

            //// ============================= Seed Courses ============================= //

            Course c1 = new Course() { Title = "C Sharp", Stream = "Object-Oriented Programming", Type = "Part time", StartDate = new DateTime(2019, 11, 18), EndDate = new DateTime(2020, 5, 31) };
            Course c2 = new Course() { Title = "JAVA", Stream = "Object-Oriented Programming", Type = "Part time", StartDate = new DateTime(2019, 11, 10), EndDate = new DateTime(2020, 5, 15) };
            Course c3 = new Course() { Title = "SQL", Stream = "Creating Databases", Type = "Part time", StartDate = new DateTime(2019, 10, 15), EndDate = new DateTime(2020, 2, 15) };
            Course c4 = new Course() { Title = "HTML / CSS", Stream = "Creating the Front-End", Type = "Part time", StartDate = new DateTime(2019, 10, 1), EndDate = new DateTime(2020, 1, 31) };
            Course c5 = new Course() { Title = "Javascript", Stream = "You do not know JacaScript", Type = "Part time", StartDate = new DateTime(2019, 10, 1), EndDate = new DateTime(2020, 1, 31) };

            // ============================= Seed Assignments ============================= //

            Assignment a1 = new Assignment() { Title = "Theory of Programming", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a2 = new Assignment() { Title = "Creating Databases", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a3 = new Assignment() { Title = "How a Network Works", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a4 = new Assignment() { Title = "Bootstrap 4.0", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a5 = new Assignment() { Title = "Learning JavaScript", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };

            Assignment a6 = new Assignment() { Title = "MVC - A Complete Tutorial", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a7 = new Assignment() { Title = "Algorithms", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a8 = new Assignment() { Title = "How to escape from a loop", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a9 = new Assignment() { Title = "Star Wars and Coding", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a10 = new Assignment() { Title = "Introduction to Advanced Programming", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };

            Assignment a11 = new Assignment() { Title = "Gaming Design", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a12 = new Assignment() { Title = "Unit Testing", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a13 = new Assignment() { Title = "How to improve the layout of a Website", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a14 = new Assignment() { Title = "Introduction to Documentation", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };
            Assignment a15 = new Assignment() { Title = "Beware of the Exception", Description = "Individual Project", SubDateTime = new DateTime(2020, 4, 3) };

            StudentAssignment st1 = new StudentAssignment() { CodeMark = 1.1F, OralMark = 30, TotalMark = 70 };
            StudentAssignment st2 = new StudentAssignment() { CodeMark = 1.2F, OralMark = 28, TotalMark = 78 };
            StudentAssignment st3 = new StudentAssignment() { CodeMark = 1.3F, OralMark = 50, TotalMark = 100 };
            StudentAssignment st4 = new StudentAssignment() { CodeMark = 1.4F, OralMark = 40, TotalMark = 90 };
            StudentAssignment st5 = new StudentAssignment() { CodeMark = 1.5F, OralMark = 25, TotalMark = 55 };
            StudentAssignment st6 = new StudentAssignment() { CodeMark = 1.6F, OralMark = 36, TotalMark = 82 };
            StudentAssignment st7 = new StudentAssignment() { CodeMark = 1.7F, OralMark = 17, TotalMark = 49 };
            StudentAssignment st8 = new StudentAssignment() { CodeMark = 1.8F, OralMark = 45, TotalMark = 90 };
            StudentAssignment st9 = new StudentAssignment() { CodeMark = 1.9F, OralMark = 34, TotalMark = 68 };

            StudentAssignment st10 = new StudentAssignment() { CodeMark = 2.1F, OralMark = 33, TotalMark = 69 };
            StudentAssignment st11 = new StudentAssignment() { CodeMark = 2.2F, OralMark = 50, TotalMark = 100 };
            StudentAssignment st12 = new StudentAssignment() { CodeMark = 2.3F, OralMark = 22, TotalMark = 52 };
            StudentAssignment st13 = new StudentAssignment() { CodeMark = 2.4F, OralMark = 41, TotalMark = 75 };
            StudentAssignment st14 = new StudentAssignment() { CodeMark = 2.5F, OralMark = 50, TotalMark = 100 };
            StudentAssignment st15 = new StudentAssignment() { CodeMark = 2.6F, OralMark = 27, TotalMark = 78 };
            StudentAssignment st16 = new StudentAssignment() { CodeMark = 2.7F, OralMark = 11, TotalMark = 34 };
            StudentAssignment st17 = new StudentAssignment() { CodeMark = 2.8F, OralMark = 30, TotalMark = 70 };
            StudentAssignment st18 = new StudentAssignment() { CodeMark = 2.9F, OralMark = 19, TotalMark = 50 };

            StudentAssignment st19 = new StudentAssignment() { CodeMark = 3.1F, OralMark = 50, TotalMark = 100 };
            StudentAssignment st20 = new StudentAssignment() { CodeMark = 3.2F, OralMark = 45, TotalMark = 93 };
            StudentAssignment st21 = new StudentAssignment() { CodeMark = 3.3F, OralMark = 35, TotalMark = 70 };
            StudentAssignment st22 = new StudentAssignment() { CodeMark = 3.4F, OralMark = 50, TotalMark = 98 };
            StudentAssignment st23 = new StudentAssignment() { CodeMark = 3.5F, OralMark = 30, TotalMark = 70 };
            StudentAssignment st24 = new StudentAssignment() { CodeMark = 3.6F, OralMark = 39, TotalMark = 60 };
            StudentAssignment st25 = new StudentAssignment() { CodeMark = 3.7F, OralMark = 43, TotalMark = 73 };
            StudentAssignment st26 = new StudentAssignment() { CodeMark = 3.8F, OralMark = 10, TotalMark = 45 };
            StudentAssignment st27 = new StudentAssignment() { CodeMark = 3.9F, OralMark = 37, TotalMark = 80 };

            StudentAssignment st28 = new StudentAssignment() { CodeMark = 4.1F, OralMark = 22, TotalMark = 55 };
            StudentAssignment st29 = new StudentAssignment() { CodeMark = 4.2F, OralMark = 23, TotalMark = 49 };
            StudentAssignment st30 = new StudentAssignment() { CodeMark = 4.3F, OralMark = 33, TotalMark = 70 };
            StudentAssignment st31 = new StudentAssignment() { CodeMark = 4.4F, OralMark = 22, TotalMark = 61 };
            StudentAssignment st32 = new StudentAssignment() { CodeMark = 4.5F, OralMark = 18, TotalMark = 48 };
            StudentAssignment st33 = new StudentAssignment() { CodeMark = 4.6F, OralMark = 44, TotalMark = 76 };
            StudentAssignment st34 = new StudentAssignment() { CodeMark = 4.7F, OralMark = 35, TotalMark = 61 };
            StudentAssignment st35 = new StudentAssignment() { CodeMark = 4.8F, OralMark = 28, TotalMark = 51 };
            StudentAssignment st36 = new StudentAssignment() { CodeMark = 4.9F, OralMark = 16, TotalMark = 47 };

            StudentAssignment st37 = new StudentAssignment() { CodeMark = 5.1F, OralMark = 32, TotalMark = 56 };
            StudentAssignment st38 = new StudentAssignment() { CodeMark = 5.2F, OralMark = 45, TotalMark = 90 };
            StudentAssignment st39 = new StudentAssignment() { CodeMark = 5.3F, OralMark = 24, TotalMark = 58 };
            StudentAssignment st40 = new StudentAssignment() { CodeMark = 5.4F, OralMark = 43, TotalMark = 69 };
            StudentAssignment st41 = new StudentAssignment() { CodeMark = 5.5F, OralMark = 22, TotalMark = 44 };
            StudentAssignment st42 = new StudentAssignment() { CodeMark = 5.6F, OralMark = 42, TotalMark = 72 };
            StudentAssignment st43 = new StudentAssignment() { CodeMark = 5.7F, OralMark = 31, TotalMark = 59 };
            StudentAssignment st44 = new StudentAssignment() { CodeMark = 5.8F, OralMark = 49, TotalMark = 100 };
            StudentAssignment st45 = new StudentAssignment() { CodeMark = 5.9F, OralMark = 29, TotalMark = 69 };

            StudentAssignment st46 = new StudentAssignment() { CodeMark = 6.1F, OralMark = 11, TotalMark = 34 };
            StudentAssignment st47 = new StudentAssignment() { CodeMark = 6.2F, OralMark = 34, TotalMark = 77 };
            StudentAssignment st48 = new StudentAssignment() { CodeMark = 6.3F, OralMark = 19, TotalMark = 50 };
            StudentAssignment st49 = new StudentAssignment() { CodeMark = 6.4F, OralMark = 50, TotalMark = 100 };
            StudentAssignment st50 = new StudentAssignment() { CodeMark = 6.5F, OralMark = 47, TotalMark = 97 };
            StudentAssignment st51 = new StudentAssignment() { CodeMark = 6.6F, OralMark = 30, TotalMark = 70 };
            StudentAssignment st52 = new StudentAssignment() { CodeMark = 6.7F, OralMark = 55, TotalMark = 98 };
            StudentAssignment st53 = new StudentAssignment() { CodeMark = 6.8F, OralMark = 30, TotalMark = 70 };
            StudentAssignment st54 = new StudentAssignment() { CodeMark = 6.9F, OralMark = 49, TotalMark = 60 };

            StudentAssignment st55 = new StudentAssignment() { CodeMark = 7.1F, OralMark = 41, TotalMark = 73 };
            StudentAssignment st56 = new StudentAssignment() { CodeMark = 7.2F, OralMark = 9, TotalMark = 39 };
            StudentAssignment st57 = new StudentAssignment() { CodeMark = 7.3F, OralMark = 37, TotalMark = 80 };
            StudentAssignment st58 = new StudentAssignment() { CodeMark = 7.4F, OralMark = 22, TotalMark = 55 };
            StudentAssignment st59 = new StudentAssignment() { CodeMark = 7.5F, OralMark = 50, TotalMark = 100 };
            StudentAssignment st60 = new StudentAssignment() { CodeMark = 7.6F, OralMark = 30, TotalMark = 70 };
            StudentAssignment st61 = new StudentAssignment() { CodeMark = 7.7F, OralMark = 30, TotalMark = 70 };
            StudentAssignment st62 = new StudentAssignment() { CodeMark = 7.8F, OralMark = 28, TotalMark = 78 };
            StudentAssignment st63 = new StudentAssignment() { CodeMark = 7.9F, OralMark = 50, TotalMark = 100 };

            StudentAssignment st64 = new StudentAssignment() { CodeMark = 8.1F, OralMark = 40, TotalMark = 90 };
            StudentAssignment st65 = new StudentAssignment() { CodeMark = 8.2F, OralMark = 25, TotalMark = 55 };
            StudentAssignment st66 = new StudentAssignment() { CodeMark = 8.3F, OralMark = 36, TotalMark = 82 };
            StudentAssignment st67 = new StudentAssignment() { CodeMark = 8.4F, OralMark = 17, TotalMark = 49 };
            StudentAssignment st68 = new StudentAssignment() { CodeMark = 8.5F, OralMark = 45, TotalMark = 90 };
            StudentAssignment st69 = new StudentAssignment() { CodeMark = 8.6F, OralMark = 34, TotalMark = 68 };
            StudentAssignment st70 = new StudentAssignment() { CodeMark = 8.7F, OralMark = 33, TotalMark = 69 };
            StudentAssignment st71 = new StudentAssignment() { CodeMark = 8.8F, OralMark = 30, TotalMark = 70 };
            StudentAssignment st72 = new StudentAssignment() { CodeMark = 8.9F, OralMark = 28, TotalMark = 78 };

            StudentAssignment st73 = new StudentAssignment() { CodeMark = 9.1F, OralMark = 50, TotalMark = 100 };
            StudentAssignment st74 = new StudentAssignment() { CodeMark = 9.2F, OralMark = 40, TotalMark = 90 };
            StudentAssignment st75 = new StudentAssignment() { CodeMark = 9.3F, OralMark = 25, TotalMark = 55 };
            StudentAssignment st76 = new StudentAssignment() { CodeMark = 9.4F, OralMark = 36, TotalMark = 82 };
            StudentAssignment st77 = new StudentAssignment() { CodeMark = 9.5F, OralMark = 17, TotalMark = 49 };
            StudentAssignment st78 = new StudentAssignment() { CodeMark = 9.6F, OralMark = 45, TotalMark = 90 };
            StudentAssignment st79 = new StudentAssignment() { CodeMark = 9.7F, OralMark = 34, TotalMark = 68 };
            StudentAssignment st80 = new StudentAssignment() { CodeMark = 9.8F, OralMark = 33, TotalMark = 69 };
            StudentAssignment st81 = new StudentAssignment() { CodeMark = 9.9F, OralMark = 9, TotalMark = 39 };

            StudentAssignment st82 = new StudentAssignment() { CodeMark = 10.1F, OralMark = 37, TotalMark = 80 };
            StudentAssignment st83 = new StudentAssignment() { CodeMark = 10.2F, OralMark = 31, TotalMark = 59 };
            StudentAssignment st84 = new StudentAssignment() { CodeMark = 10.3F, OralMark = 49, TotalMark = 100 };
            StudentAssignment st85 = new StudentAssignment() { CodeMark = 10.4F, OralMark = 29, TotalMark = 69 };
            StudentAssignment st86 = new StudentAssignment() { CodeMark = 10.5F, OralMark = 17, TotalMark = 47 };
            StudentAssignment st87 = new StudentAssignment() { CodeMark = 10.6F, OralMark = 33, TotalMark = 56 };
            StudentAssignment st88 = new StudentAssignment() { CodeMark = 10.7F, OralMark = 45, TotalMark = 67 };
            StudentAssignment st89 = new StudentAssignment() { CodeMark = 10.8F, OralMark = 47, TotalMark = 94 };
            StudentAssignment st90 = new StudentAssignment() { CodeMark = 10.9F, OralMark = 30, TotalMark = 70 };

            // ============================= Seed Photos to trainers ============================= //

            //Gatsos
            Photo p1 = new Photo() { Url = "https://www.spoudasefest.gr/sites/default/files/styles/square/public/fotografia_gkatsos_1.jpg?itok=b24D-IUm" };
            //Stroggylos
            Photo p2 = new Photo() { Url = "https://media-exp1.licdn.com/dms/image/C5103AQFMQARMZAJc-Q/profile-displayphoto-shrink_200_200/0?e=1591228800&v=beta&t=4oF5svfJ3grFBBFAY4XDoAsQ8Mf5x10_m03TRHzp4Us" };
            //Minaidis
            Photo p3 = new Photo() { Url = "https://media-exp1.licdn.com/dms/image/C5603AQEZa66_oACjRQ/profile-displayphoto-shrink_200_200/0?e=1591228800&v=beta&t=pQgKNBr8Vs2M1uwSeAmu-XowhGyzKKDY3HskaZKMs0g" };
            //Pasparakis
            Photo p4 = new Photo() { Url = "https://media-exp1.licdn.com/dms/image/C4E03AQFWuZhYfo-rbg/profile-displayphoto-shrink_200_200/0?e=1591228800&v=beta&t=PNH7FDqedpAuPbKQgLFAfC9plw8ZKLfHecJHYnSLfOo" };
            //Tzelepopoulos
            Photo p5 = new Photo() { Url = "https://media-exp1.licdn.com/dms/image/C4D03AQEZPamciZzPLQ/profile-displayphoto-shrink_200_200/0?e=1591228800&v=beta&t=r5xRCQgiIJFxpoi2Tw5hU4Qz8MDgvTmwwnVcxtPeytU" };

            //Vlachogiannis
            Photo p6 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/54428305_798369990539121_110863100298657792_n.jpg?_nc_cat=102&_nc_sid=09cbfe&_nc_eui2=AeG7B3JmDoRv6z7LMLJ7wALZMp0zZkEahy0ynTNmQRqHLfrKLYRo4JvzH0l2f3mGuI8&_nc_ohc=FLuw-nBKRPwAX93rvDi&_nc_ht=scontent.fath7-1.fna&oh=8feecf28f8ffecabb3bcc95f611b248c&oe=5EAFA3B8" };
            //Poulakos
            Photo p7 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/11223500_10209517569990437_2721583729822017636_n.jpg?_nc_cat=102&_nc_sid=174925&_nc_eui2=AeFjJTzXB2AWI9LVN1xKKsDb2K4x1mHCm4PYrjHWYcKbg7bVAJgpm1KtlwhY-sJJR0I&_nc_ohc=PZJ0Mw2NQY0AX_Ui9iH&_nc_ht=scontent.fath7-1.fna&oh=a18e8e93bd7cd215274a0ed5e26d7744&oe=5EAC8618" };
            //Parisi
            Photo p8 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/44643459_1990574251006318_6459707710278467584_o.jpg?_nc_cat=105&_nc_sid=09cbfe&_nc_eui2=AeG1kdTyIXliASaATv2SADupVvQLfjSphLNW9At-NKmEs7R40DWOfD1k3zaJQfdPtG0&_nc_ohc=8iH58A9S0v0AX-4rahh&_nc_ht=scontent.fath7-1.fna&oh=2c28ce2c016d14d57e3c9e8e14a452a3&oe=5EACBD58" };
            //Kannellis
            Photo p9 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t31.0-8/p960x960/285972_2085671995911_1552357_o.jpg?_nc_cat=107&_nc_sid=09cbfe&_nc_eui2=AeEUMTGCvKNnsitEZsuwbjZ893PzOzg31XL3c_M7ODfVcg-N5Yj6HY6TQ0qPnjj2Vco&_nc_ohc=BD7IR4mvbFUAX8l2r3t&_nc_ht=scontent.fath7-1.fna&_nc_tp=6&oh=d56a1defc936ab62e4abd496ab41e1d6&oe=5EAE7969" };
            //Koutsogiorgos
            Photo p10 = new Photo() { Url = "https://cdn4.iconfinder.com/data/icons/people-avatar-1-2/512/7-512.png" };
            //Zacharias
            Photo p11 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t31.0-8/27747689_1760922243939546_4872129996443956546_o.jpg?_nc_cat=105&_nc_sid=09cbfe&_nc_eui2=AeEcLddiLn7AUvGcWU-OiNSTKDS_j7AF2vYoNL-PsAXa9hhx7u6OTdfbuFyeBs5YShs&_nc_ohc=PvxCieEs-ZgAX-bFmx3&_nc_ht=scontent.fath7-1.fna&oh=d42e0c9a08e4a38a2163b180d7e29fe1&oe=5EAE8BE0" };
            //Theodoropoulos
            Photo p12 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/49664349_10216999360366938_5900649280695173120_o.jpg?_nc_cat=101&_nc_sid=174925&_nc_eui2=AeE_1BNvtyxT7CmXGRhnpV1ZX374MGqjuKJffvgwaqO4onPaWaruVkJXucG31TNMtEA&_nc_ohc=PEBDFGAG6joAX-YTuRR&_nc_ht=scontent.fath7-1.fna&oh=96bde7179fb870635cb98169b39c8f5b&oe=5EAC5081" };
            //Papageorgiou
            Photo p13 = new Photo() { Url = "https://lh3.googleusercontent.com/proxy/1yik8SAqLbx7w170R89AAzv8gQwZKamtLdLdIdWZd_LuzD2-O7KBnK2YtJjglJo5D3UnF7fckyhIKh3egzkoWZij190k4xmPgweYQckZ5IC-YIzClj8kAgj0M5I7CHsd-po" };
            //Katrakis
            Photo p14 = new Photo() { Url = "https://i.ya-webdesign.com/images/png-avatar-4.png" };
            //Christidis
            Photo p15 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/56586007_10216725716129156_2117505407634112512_o.jpg?_nc_cat=109&_nc_sid=174925&_nc_eui2=AeHzjQdAD0zy6LxHRV_2NoJtqQnThTvgQeupCdOFO-BB61YDSQ5CEDsZ1G0QMBtw8XI&_nc_ohc=4hd2PuXO73sAX8X9HJI&_nc_ht=scontent.fath7-1.fna&oh=f55a94d1895c609444d0fc1f6f4b8687&oe=5EAD3F72" };
            //Rizos
            Photo p16 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t31.0-8/16826073_1887513254864184_8287403750433117992_o.jpg?_nc_cat=100&_nc_sid=09cbfe&_nc_eui2=AeFqTo9W4fGvTsI4Ji65felOFYdrc2DpO3gVh2tzYOk7eELvxDvtZiaYIW4cM7nBiUY&_nc_ohc=y8Y-kMo4ebIAX_-Cr--&_nc_ht=scontent.fath7-1.fna&oh=d7b8d8b4fd9481dda9230cddeb7fe6c1&oe=5EAF55AB" };
            //Adam
            Photo p17 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/44344420_1087584488068593_4637956778598858752_o.jpg?_nc_cat=111&_nc_sid=174925&_nc_eui2=AeGKeAHxl0QqZzlrnw8wxWLyZcB-8RH_jJdlwH7xEf-Ml7khErVoNiANBP7xmFidOSY&_nc_ohc=ZQ3USL_5DH0AX_ZaeJo&_nc_ht=scontent.fath7-1.fna&oh=344521c82253750dda748397b882b363&oe=5EB0217B" };
            //Argyropoulos
            Photo p18 = new Photo() { Url = "https://f0.pngfuel.com/png/592/884/black-and-white-cartoon-character-programmer-computer-programming-computer-software-computer-icons-programming-language-avatar-png-clip-art.png" };
            //Karol
            Photo p19 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/s1080x2048/60247548_1531966373605919_5288819833486442496_o.jpg?_nc_cat=106&_nc_sid=09cbfe&_nc_eui2=AeEPXt1DNWI2kAblqEHTEOexL0tOojae4VwvS06iNp7hXFZB3op02sXyiwV-rV7zUM0&_nc_ohc=noA78_rrYRYAX-HRoC4&_nc_ht=scontent.fath7-1.fna&_nc_tp=7&oh=8a9c45a29613305b7789b7696b0cb441&oe=5EAD7A2C" };
            //Manthos
            Photo p20 = new Photo() { Url = "https://cdn2.iconfinder.com/data/icons/characters-1/100/user_4_018-512.png" };
            //Elefsiniotis
            Photo p21 = new Photo() { Url = "https://cdn.iconscout.com/icon/free/png-512/avatar-380-456332.png" };
            //Panagoulias
            Photo p22 = new Photo() { Url = "https://lh3.googleusercontent.com/proxy/KVZZMFmUdm-zAlI5WEuVtUJJ6ncmeo0j2SXRhi04lNENBnjZI9pdGzddJgAAGwL-8duFmNbNYJsSt-lX0-vXge_OpGF1RqBXPTmzbwCrG2LSVuNfVS3xycX964WS2EQoRBc" };
            //Pilikas
            Photo p23 = new Photo() { Url = "https://c7.uihere.com/files/340/946/334/avatar-user-computer-icons-software-developer-avatar.jpg" };
            //Vasilakis 
            Photo p24 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/39755150_2135619819844294_8578400753679335424_n.jpg?_nc_cat=101&_nc_sid=09cbfe&_nc_eui2=AeE6Alm5f2VdqJSPklEYtRMh7dXu87lszgzt1e7zuWzODNhbc0Xkx4lqvzAPc_djuiA&_nc_ohc=rgfwzg_2ChAAX_Ipyfp&_nc_ht=scontent.fath7-1.fna&oh=52d5f90e3894a053b2faf6ca7e0938d3&oe=5EAEF312" };
            //Kontodimas
            Photo p25 = new Photo() { Url = "https://cdn.iconscout.com/icon/free/png-512/avatar-367-456319.png" };
            //Perikleous
            Photo p26 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/71095731_2515918931835750_1274777998901379072_n.jpg?_nc_cat=110&_nc_sid=174925&_nc_eui2=AeEzhXg1BHP2-2AChrKnL8m0NeXyXRDw7gw15fJdEPDuDNaLdN3zPjyhy_F5zjVYoeI&_nc_ohc=VrpA_bv0LzQAX_HnhyR&_nc_ht=scontent.fath7-1.fna&oh=165f5a4f5763dc28b014a124e0150d43&oe=5EAF3E6F" };
            //Alikaj
            Photo p27 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/84947519_10221639470159874_2595289818887880704_o.jpg?_nc_cat=108&_nc_sid=09cbfe&_nc_eui2=AeFI0JfPaJDlMzxVzpjG5YU9tkKIX7-cJ-u2Qohfv5wn6zU5Be4wNgjpC_Tow5zx94I&_nc_ohc=T3CFXbOgRdIAX8REHsC&_nc_ht=scontent.fath7-1.fna&oh=548b02f7e48853eb42afd15adea7c133&oe=5EACC869" };
            //Bourbopoulos 
            Photo p28 = new Photo() { Url = "https://images.assetsdelivery.com/compings_v2/jegas/jegas1704/jegas170400202.jpg" };
            //Papadopoulos 
            Photo p29 = new Photo() { Url = "https://toppng.com/uploads/preview/cool-avatar-transparent-image-cool-boy-avatar-11562893383qsirclznyw.png" };
            //Litinas 
            Photo p30 = new Photo() { Url = "https://www.vippng.com/png/detail/205-2051554_avatar-profile-png-icon-gamer-avatar-png.png" };
            //Karaplis
            Photo p31 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/23905491_1363737283735263_1461231550989927704_n.jpg?_nc_cat=100&_nc_sid=174925&_nc_eui2=AeFRC-Hzx2oeF7jrcMD8ajUP6lPRtWw5IxrqU9G1bDkjGgSFDHtrOENkMCLM_MejEmo&_nc_ohc=0DH9Yh4B28QAX8_KUoJ&_nc_ht=scontent.fath7-1.fna&oh=e8a66cc49fa5297624c656ca966fc562&oe=5EAE03C3" };
            //Makris 
            Photo p32 = new Photo() { Url = "https://img.favpng.com/20/11/10/computer-icons-icon-design-png-favpng-8Hk26AsZVcQbfXKf83GxDkCZS.jpg" };
            //"Kanellopoulos 
            Photo p33 = new Photo() { Url = "https://scontent.fath7-1.fna.fbcdn.net/v/t1.0-9/62591227_10219373182178317_4213484632454201344_o.jpg?_nc_cat=107&_nc_sid=09cbfe&_nc_eui2=AeGF6L2IRVPKS8lQqFvd3JJDB3rt67jfstIHeu3ruN-y0je3JbBubjrK25ndM8EL0ng&_nc_ohc=OscnIVvwcYIAX-72KtJ&_nc_ht=scontent.fath7-1.fna&oh=72daa0131fc3cb6170e6a37b704b3bd6&oe=5EAE80F3" };
            //Benveniste  
            Photo p34 = new Photo() { Url = "https://cdn.iconscout.com/icon/free/png-512/avatar-375-456327.png" };
            //Leonidakis 
            Photo p35 = new Photo() { Url = "https://cdn.clipart.email/de5ba447b4907e155ea688026d2684c4_avatar-user-logo-png_360-360.jpeg" };

            // ============================= Add Photos to students ============================= //
            p6.Student = s1;
            p7.Student = s2;
            p8.Student = s3;
            p9.Student = s4;
            p10.Student = s5;
            p11.Student = s6;
            p12.Student = s7;
            p13.Student = s8;
            p14.Student = s9;
            p15.Student = s10;
            p16.Student = s11;
            p17.Student = s12;
            p18.Student = s13;
            p19.Student = s14;
            p20.Student = s15;
            p21.Student = s16;
            p22.Student = s17;
            p23.Student = s18;
            p24.Student = s19;
            p25.Student = s20;
            p26.Student = s21;
            p27.Student = s22;
            p28.Student = s23;
            p29.Student = s24;
            p30.Student = s25;
            p31.Student = s26;
            p32.Student = s27;
            p33.Student = s28;
            p34.Student = s29;
            p35.Student = s30;

            // ==================== Add Photos to Trainers ==================== //
            p1.Trainer = t1;
            p2.Trainer = t2;
            p3.Trainer = t3;
            p4.Trainer = t4;
            p5.Trainer = t5;

            // ==================== Add Trainers to Courses ==================== //
            t1.Courses = new List<Course>() { c1, c4 };
            t2.Courses = new List<Course>() { c3 };
            t3.Courses = new List<Course>() { c5, c4 };
            t4.Courses = new List<Course>() { c2, c5 };
            t5.Courses = new List<Course>() { c4 };

            // ==================== Add Students to Courses ==================== //
            c1.Students = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            c2.Students = new List<Student>() { s7, s8, s9, s10, s11, s12 };
            c3.Students = new List<Student>() { s13, s14, s15, s16, s17, s18 };
            c4.Students = new List<Student>() { s19, s20, s21, s22, s23, s24 };
            c5.Students = new List<Student>() { s25, s26, s27, s28, s29, s30 };

            // ==================== Add Assignments to Courses ==================== //
            c1.Assignments = new List<Assignment>() { a1, a2, a3 };
            c2.Assignments = new List<Assignment>() { a4, a5, a6 };
            c3.Assignments = new List<Assignment>() { a7, a8, a9 };
            c4.Assignments = new List<Assignment>() { a10, a11, a12 };
            c5.Assignments = new List<Assignment>() { a13, a14, a15 };

            // ==================== Add Marks to StudentPerAssignment ==================== //
            st1.Student = s1;
            st1.Assignment = a1;
            st2.Student = s1;
            st2.Assignment = a2;
            st3.Student = s1;
            st3.Assignment = a3;

            st4.Student = s2;
            st4.Assignment = a4;
            st5.Student = s2;
            st5.Assignment = a5;
            st6.Student = s2;
            st6.Assignment = a6;

            st7.Student = s3;
            st7.Assignment = a7;
            st8.Student = s3;
            st8.Assignment = a8;
            st9.Student = s3;
            st9.Assignment = a9;

            st10.Student = s4;
            st10.Assignment = a10;
            st11.Student = s4;
            st11.Assignment = a11;
            st12.Student = s4;
            st12.Assignment = a12;

            st13.Student = s5;
            st13.Assignment = a13;
            st14.Student = s5;
            st14.Assignment = a14;
            st15.Student = s5;
            st15.Assignment = a15;

            st16.Student = s6;
            st16.Assignment = a1;
            st17.Student = s6;
            st17.Assignment = a2;
            st18.Student = s6;
            st18.Assignment = a3;

            st19.Student = s7;
            st19.Assignment = a4;
            st20.Student = s7;
            st20.Assignment = a5;
            st21.Student = s7;
            st21.Assignment = a6;

            st22.Student = s8;
            st22.Assignment = a7;
            st23.Student = s8;
            st23.Assignment = a8;
            st24.Student = s8;
            st24.Assignment = a9;

            st25.Student = s9;
            st25.Assignment = a10;
            st26.Student = s9;
            st26.Assignment = a11;
            st27.Student = s9;
            st27.Assignment = a12;

            st28.Student = s10;
            st28.Assignment = a13;
            st29.Student = s10;
            st29.Assignment = a14;
            st30.Student = s10;
            st30.Assignment = a15;

            st31.Student = s11;
            st31.Assignment = a1;
            st32.Student = s11;
            st32.Assignment = a2;
            st33.Student = s11;
            st33.Assignment = a3;

            st34.Student = s12;
            st34.Assignment = a4;
            st35.Student = s12;
            st35.Assignment = a5;
            st36.Student = s12;
            st36.Assignment = a6;

            st37.Student = s13;
            st37.Assignment = a7;
            st38.Student = s13;
            st38.Assignment = a8;
            st39.Student = s13;
            st39.Assignment = a9;

            st40.Student = s14;
            st40.Assignment = a10;
            st41.Student = s14;
            st41.Assignment = a11;
            st42.Student = s14;
            st42.Assignment = a12;

            st43.Student = s15;
            st43.Assignment = a13;
            st44.Student = s15;
            st44.Assignment = a14;
            st45.Student = s15;
            st45.Assignment = a15;

            st46.Student = s16;
            st46.Assignment = a1;
            st47.Student = s16;
            st47.Assignment = a2;
            st48.Student = s16;
            st48.Assignment = a3;

            st49.Student = s17;
            st49.Assignment = a4;
            st50.Student = s17;
            st50.Assignment = a5;
            st51.Student = s17;
            st51.Assignment = a6;

            st52.Student = s18;
            st52.Assignment = a7;
            st53.Student = s18;
            st53.Assignment = a8;
            st54.Student = s18;
            st54.Assignment = a9;

            st55.Student = s19;
            st55.Assignment = a10;
            st56.Student = s19;
            st56.Assignment = a11;
            st57.Student = s19;
            st57.Assignment = a12;

            st58.Student = s20;
            st58.Assignment = a13;
            st59.Student = s20;
            st59.Assignment = a14;
            st60.Student = s20;
            st60.Assignment = a15;

            st61.Student = s21;
            st61.Assignment = a1;
            st62.Student = s21;
            st62.Assignment = a2;
            st63.Student = s21;
            st63.Assignment = a3;

            st64.Student = s22;
            st64.Assignment = a4;
            st65.Student = s22;
            st65.Assignment = a5;
            st66.Student = s22;
            st66.Assignment = a6;

            st67.Student = s23;
            st67.Assignment = a7;
            st68.Student = s23;
            st68.Assignment = a8;
            st69.Student = s23;
            st69.Assignment = a9;

            st70.Student = s24;
            st70.Assignment = a10;
            st71.Student = s24;
            st71.Assignment = a11;
            st72.Student = s24;
            st72.Assignment = a12;

            st73.Student = s25;
            st73.Assignment = a13;
            st74.Student = s25;
            st74.Assignment = a14;
            st75.Student = s25;
            st75.Assignment = a15;

            st76.Student = s26;
            st76.Assignment = a1;
            st77.Student = s26;
            st77.Assignment = a2;
            st78.Student = s26;
            st78.Assignment = a3;

            st79.Student = s27;
            st79.Assignment = a4;
            st80.Student = s27;
            st80.Assignment = a5;
            st81.Student = s27;
            st81.Assignment = a6;

            st82.Student = s28;
            st82.Assignment = a7;
            st83.Student = s28;
            st83.Assignment = a8;
            st84.Student = s28;
            st84.Assignment = a9;

            st85.Student = s29;
            st85.Assignment = a10;
            st86.Student = s29;
            st86.Assignment = a11;
            st87.Student = s29;
            st87.Assignment = a12;

            st88.Student = s30;
            st88.Assignment = a13;
            st89.Student = s30;
            st89.Assignment = a14;
            st90.Student = s30;
            st90.Assignment = a15;


            // ==================== Upsert Tables ==================== //
            context.Photos.AddOrUpdate(x => x.Url, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35);
            context.Students.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30);
            context.Trainers.AddOrUpdate(x => x.LastName, t1, t2, t3, t4, t5);
            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3, c4, c5);
            context.Assignments.AddOrUpdate(x => x.Title, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15);
            context.StudentAssignments.AddOrUpdate(x => x.CodeMark, st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15, st16, st17, st18, st19, st20, st21, st22, st23, st24, st25, st26, st27, st28, st29, st30, st31, st32,
                                                                     st33, st34, st35, st36, st37, st38, st39, st40, st41, st42, st43, st44, st45, st46, st47, st48, st49, st50, st51, st52, st53, st54, st55, st56, st57, st58, st59, st60,
                                                                     st61, st62, st63, st64, st65, st66, st67, st68, st69, st70, st71, st72, st73, st74, st75, st76, st77, st78, st79, st80, st81, st82, st83, st84, st85, st86, st87, st88, st89, st90);
            context.SaveChanges();
        }
    }
}
