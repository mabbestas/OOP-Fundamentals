# OOP-Fundamentals

## What is OOP?
Object-oriented programming is one of the most important programming paradigms. It is a system of principles that define what basic logic we use to solve a given task and to structure our programs, and how elements of the code are connected to each other.
![Object-Oriented-Programming-with-Java-I](https://user-images.githubusercontent.com/103368662/196721770-8fcee7d0-31e8-47d2-a278-940b62bd819b.jpg)
## Advantages of OOP
* It is easier to model complex things as simpler, more reproducible structures
* The code is easily reusable
* We can create programs that run faster with it
* The structure of the code is more transparent
* Development is faster because parallel classes can be developed at the same time
* The program can be modified, debugged, and maintained easier
* It is safer (encapsulation and abstraction makes data more secure) 

![oop-principles](https://user-images.githubusercontent.com/103368662/197407942-6ab70215-0df7-47de-87c1-0d8cc0f55895.jpg)

## Encapsulation
Encapsulation is the mechanism of hiding of data implementation by restricting access to public methods. In encapsulation, the variables of a class will be hidden from other classes, and can be accessed only through the methods of their current class. Therefore, it is also known as data hiding. 
* Encapsulation solves it implementation level.
* Encapsulation means binding the code and data into a single unit.
* Encapsulation means hiding the internal details or mechanics of how an object does something for security reasons.

## Inheritance
Inheritance refers to the ability of an object to take on one or more characteristics from other classes of objects. The characteristics inherited are usually instance variables or member functions. An object that inherits these characteristics is known as a subclass. The object it inherits them from is known as a superclass. There are five types of inheritance:
* Single inheritance - Subclasses inherit characteristics from a single superclass.
* Multiple inheritance - A subclass may have more than one superclass and inherit characteristics from all of them.
* Multilevel inheritance - A subclass may have its own subclasses. In other words, a subclass of a superclass can itself be a superclass to other subclasses.
* Hierarchical inheritance - A base class acts as the parent superclass to multiple levels of subclasses.
* Hybrid inheritance - A combination of one or more of the other inheritance types.

## Polymorphism
Polymorphism is an object-oriented programming concept that refers to the ability of a variable, function, or object to take on multiple forms. Polymorphism helps programmers reuse code and classes once written, tested, and implemented. A single variable name can be used to store variables of multiple data types. It helps compose powerful, complex abstractions from simpler ones. There are two types of polymorphism:
* **Compile time polymorphism**: Method overloading
* **Runtime polymorphism**: Method overriding

## Abstraction
The main purpose of abstraction is hiding the unnecessary details from the users. Abstraction is selecting data from a larger pool to show only relevant details of the object to the user. It helps in reducing programming complexity and efforts.
* Abstraction in Object Oriented Programming solves the issues at the design level.
* Abstraction in Programming is about hiding unwanted details while showing most essential information.
* An abstract class can have both abstract and non-abstract methods.
* It does not support multiple inheritances.
* It can provide the implementation of the interface.
* An abstract class can have protected and abstract public methods.
* An abstract class can have final, static, or static final variable with any access specifier.

## Interface
An interface is a completely “abstract class” that is used to group related methods with empty bodies. Interface defines what operations a class can perform. An interface declares the properties and methods. It is up to the class to define exactly what the method will do.
* The interface can have only abstract methods.
* It supports multiple inheritances.
* It can not provide the implementation of the abstract class.
* An interface can have only have public abstract methods.
* The interface can only have a public static final variable.
* The enhancement will become very easy because we can change our internal implementation without affecting the outside person.
