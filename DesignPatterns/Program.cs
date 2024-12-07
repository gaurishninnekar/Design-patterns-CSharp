
// 1:Encapsulation : It refers to the practice of bundling the data(fields) and methods(functions) that operate of data into a single unit.
// Typically, a class, and restricting direct access to some  of the object's components.
// This is done in order to have a controlled access and maintain the intigrity of the data.

// using DesignPatterns.Src.OOPPrinciples.Encapsulation;

// BankAccount bankaccount = new BankAccount(100);

// Console.WriteLine(bankaccount.GetBalance());
// bankaccount.Deposit(50);
// Console.WriteLine(bankaccount.GetBalance());
// bankaccount.Withdraw(410);
// Console.WriteLine(bankaccount.GetBalance());

/*------------------------------------------------------------------------------------------------------------------------------------------*/

//2: Abstraction: It refers to a practice of hiding the core complex implementation details of the system
// and exposing only the essential features or functionality to the user. This simplifies the interaction
// with the system by providing  a high-level interface and reduce the complexity.


// using DesignPatterns.Src.OOPPrinciples.Abstraction;

// EmailService emailService = new EmailService();

// emailService.SendEmail();

/*------------------------------------------------------------------------------------------------------------------------------------------*/


// 3: Inheristance involves creating a new class ( subclass or derived class) from an existing class or baseclas.
// So as to pass down the properties and behaviours to other class and using the features or modifying them.
// It is described as "Is-a" relationship.

// using DesignPatterns.Src.OOPPrinciples.Inheritance;

// Vehicle vehicle = new Vehicle("honda", "Hornet", true, 2);
// vehicle.Details();

// // method hiding :  Using the  new keyword we hide the  base class method in order to decide the method calls depending onthe refernce  type
// Vehicle bike = new Bike("bajaj", "dominar", true, 2, true);
// bike.Details();

// Bike bike2 = new Bike("yamaha", "mt15", true, 2, false);
// bike2.Details();

/*------------------------------------------------------------------------------------------------------------------------------------------*/

//4: Polymorphism:  It allows methods to do different things based on the object it is acting upon.
//In simpler terms, polymorphism lets you call the same method on different objects, and each object will respond in its own way.


// using DesignPatterns.Src.OOPPrinciples.Polymorphism;

// //method overiding:  THis refers to the runtime polymorphism where the method call depends on the type of the object. That is the derived class have overridden the functionality.
// Parent parent = new Parent("Geeta", 51, true);
// parent.Drive();

// Parent parent2 = new Child("gaurish", 16, false, "CMRIT");
// parent2.Drive();

/*------------------------------------------------------------------------------------------------------------------------------------------*/

//5: Coupling: The degree of dependency between different classes

// using DesignPatterns.Src.OOPPrinciples.Coupling;

// Order order = new Order(new SMSService());
// order.PlaceOrder();

/*------------------------------------------------------------------------------------------------------------------------------------------*/

//6: Composition: Involves creating complex objects by combining simpler objects or components. In compostion objects are assembled together to form a larger strcutres with each component object maintaing its own state and behaviour.
//has-a relationship

// using DesignPatterns.Src.OOPPrinciples.Composition;

// Car car = new Car();
// car.StartTheCar();


// when to use Composition

// - when you need more flexibility in constructing objects by assembling smaller, reusable components.
// - when there is not clear "is-a" relationship between classes, and a "has-a" relationship is ModuleReference appropriate.

//when to use Inheritance

//when there is clear "is-a" relationship between classes, and subclass objects can be treated aas instance of their superclass.
// when  you want to promote the code resue by inheriting proportion and behaviour from exisitng classes.
// when you want polymorphism.

