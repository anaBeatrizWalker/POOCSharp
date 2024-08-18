using POOCSharp.Models;

//Concretização da representação de uma pessoa
Person p1 = new Person("Ana");
p1.Age = 22;
// p1.IntroduceYourself();

CheckingAccount c1 = new CheckingAccount(1223, 1000);
// c1.ShowBalance();
// c1.Withdraw(1200);
// c1.ShowBalance();

Student a1 = new Student("Gustavo");
a1.Email = "gustavo@gustavo.com";
a1.Age = 24;
a1.Score = 10;
// a1.IntroduceYourself();

Teacher t1 = new Teacher();
t1.Name = "Leonardo";
t1.Email = "leonardo@leonardo.com";
t1.Age = 45;
t1.Salary = 8750;
// t1.IntroduceYourself();

Checking checkingAccount = new Checking();
checkingAccount.Credit(500);
// checkingAccount.ShowBalance();

Computer computer = new Computer();
computer.ToString();
computer.GetHashCode();
Console.WriteLine(computer.ToString());