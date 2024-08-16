using POOCSharp.Models;

//Concretização da representação de uma pessoa
Person p1 = new Person();
p1.Name = "Ana";
p1.Age = 22;
p1.IntroduceYourself();

CheckingAccount c1 = new CheckingAccount(1223, 1000);
c1.ShowBalance();
c1.Withdraw(1200);
c1.ShowBalance();