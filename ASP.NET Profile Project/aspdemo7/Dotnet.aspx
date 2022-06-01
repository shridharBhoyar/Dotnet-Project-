<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dotnet.aspx.cs" Inherits="aspdemo7.Csharf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="min-width:400px; max-width:1200px;font-size:18px; font-family:Arial;">
         <h1 class="text-center">Dotnet Framwork</h1>
                <p style="font-size:18px; font-family:Arial; color:black; padding-left:80px">
    
          .Net Framework is a software development platform developed by Microsoft for building and running 
           Windows applications. The .Net framework consists of developer tools, programming languages, and
           libraries to build desktop and web applications. It is also used to build websites, web services,
           and games.<br>
                    <br>
           The .Net framework was meant to create applications, which would run on the Windows Platform. The
           first version of the .Net framework was released in the year 2002. The version was called .Net 
           framework 1.0. The Microsoft <br>
          .Net framework has come a long way since then, and the current version is .Net Framework 4.7.2.
          The Microsoft .Net framework can be used to create both – Form-based and Web-based applications. Web 
          services can also be developed using the .Net framework.<br>
                    <br>

          The framework also supports various programming languages such as Visual Basic and C#. So developers
          can choose and select the language to develop the required application. In this chapter, you will learn
          some basics of the .Net framework.<br>
                    <br>
                    <br>
           
          (1) Common Language Runtime or CLR<br>
                 It performs memory management, exception handling, debugging, security checking, thread execution,
                 code execution, code safety, verification, and compilation. The code that is directly managed by 
                 the CLR is called the managed code. When the managed code is compiled, the compiler converts the
                 source code into a CPU independent intermediate language (IL) code. A Just In Time(JIT) compiler
                 compiles the IL code into native code, which is CPU specific.<br>
                    <br>
         (2) .Net Framework Class Library<br>
                 It contains a huge library of reusable types. classes, interfaces, structures, and enumerated 
                 values, which are collectively called types.<br>
                    <br>
         (3) Common Language Specification<br>
                 It contains the specifications for the .Net supported languages and implementation of language
                 integration.<br>
                    <br>
         (4) Common Type System      <br>
                 It provides guidelines for declaring, using, and managing types at runtime, and cross-language 
                 communication.<br>
                    <br>
        (5) Metadata and Assemblies  <br>
                 Metadata is the binary information describing the program, which is either stored in a portable
                 executable file (PE) or in the memory. Assembly is a logical unit consisting of the assembly 
                 manifest, type metadata, IL code, and a set of resources like image files.<br>
                    <br>
        (6) Windows Forms <br>           
                 Windows Forms contain the graphical representation of any window displayed in the application.<br>
                    <br>
        (7) ASP.NET and ASP.NET AJAX <br>
                 ASP.NET is the web development model and AJAX is an extension of ASP.NET for developing and 
                 implementing AJAX functionality. ASP.NET AJAX contains the components that allow the developer 
                 to update data on a website without a complete reload of the page.<br>
       <br>


       <mark>.NET Components</mark> <br>
        The architecture of .Net framework is based on the following key components;
       1. Common Language Runtime<br>
       The “Common Language Infrastructure” or CLI is a platform in .Net architecture
       on which the .Net programs are executed.<br>
                    <br>
       The CLI has the following key features:<br>
       Exception Handling – Exceptions are errors which occur when the application
       is executed.<br>
                    <br>
       Examples of exceptions are:<br>
           If an application tries to open a file on the local machine, but the file is 
           not present.<br>
           If the application tries to fetch some records from a database, but the connection
           to the database is not valid<br>
                    <br>
        Garbage Collection – Garbage collection is the process of removing unwanted resources
        when they are no longer required.<br>
        Examples of garbage collection are<br>
	    A File handle which is no longer required. If the application has finished all operations 
        on a file, then the file handle may no longer be required.The database connection is no longer
        required. If the application has finished all operations on a database, then the database 
        connection may no longer be required.<br>
        Working with Various programming languages –<br>
                    <br>
       As noted in an earlier section, a developer can develop an application in a 
       variety of .Net programming languages.<br>
                    <br>
       Language – The first level is the programming language itself, the most common 
       ones are VB.Net and C#.<br>
                    <br>
       Compiler – There is a compiler which will be separate for each programming language.
            So underlying the VB.Net language, there will be a separate VB.Net compiler.
            Similarly, for C#, you will have another compiler.<br>
                    <br>
      Common Language Interpreter – This is the final layer in .Net which would be
            used to run a .net program developed in any programming language. So the subsequent
            compiler will send the program to the CLI layer to run the .Net application.<br>
                    <br>

          <mark>2. Class Library</mark><br>
        The .NET Framework includes a set of standard class libraries. A class library is a 
        collection of methods and functions that can be used for the core purpose.
        For example, there is a class library with methods to handle all file-level operations.
        So there is a method which can be used to read the text from a file. Similarly,
        there is a method to write text to a file.<br>
                    <br>
        Most of the methods are split into either the System.* or Microsoft.* namespaces.
        (The asterisk * just means a reference to all of the methods that fall under the System 
        or Microsoft namespace)<br>
        A namespace is a logical separation of methods. We will learn these namespaces more in
        detail in the subsequent chapters.<br>
<br>
         <mark>3. Languages</mark>
        The types of applications that can be built in the .Net framework is classified broadly
        into the following categories.<br>
                    <br>
       WinForms – This is used for developing Forms-based applications, which would run on an
       end user machine. Notepad is an example of a client-based application.<br>
                    <br>
      ASP.Net – This is used for developing web-based applications, which are made to run on
      any browser such as Internet Explorer, Chrome or Firefox. The Web application would be
      processed on a server, which would have Internet Information Services Installed. Internet
      Information Services or IIS is a Microsoft component which is used to execute an Asp.Net 
      application.<br>
	  The result of the execution is then sent to the client machines, and the output is shown 
      in the browser.<br>
                    <br>
      ADO.Net – This technology is used to develop applications to interact with Databases 
      such as Oracle or Microsoft SQL Server. Microsoft always ensures that .Net frameworks are 
      in compliance with all the supported Windows operating systems.<br>


                </p>
            </div>
        </div>
        
    </div>







   <%-- <p>
     <pre id="contentss">--%>



<%--         ASP.NET is a web development platform, which provides a programming model, a comprehensive software infrastructure and various services required to build up robust web applications for PC, as well as mobile devices.
ASP.NET works on top of the HTTP protocol, and uses the HTTP commands and policies to set a browser-to-server bilateral communication and cooperation.
ASP.NET is a part of Microsoft .Net platform. ASP.NET applications are compiled codes, written using the extensible and reusable components or objects present in .Net framework. These codes can use the entire hierarchy of classes in .Net framework.
The ASP.NET application codes can be written in any of the following languages:
•	C#
•	Visual Basic.Net
•	Jscript
•	J#
ASP.NET is used to produce interactive, data-driven web applications over the internet. It consists of a large number of controls such as text boxes, buttons, and labels for assembling, configuring, and manipulating code to create HTML pages.
ASP.NET Web Forms Model
ASP.NET web forms extend the event-driven model of interaction to the web applications. The browser submits a web form to the web server and the server returns a full markup page or HTML page in response.
All client side user activities are forwarded to the server for stateful processing. The server processes the output of the client actions and triggers the reactions.
Now, HTTP is a stateless protocol. ASP.NET framework helps in storing the information regarding the state of the application, which consists of:
•	Page state
•	Session state
The page state is the state of the client, i.e., the content of various input fields in the web form. The session state is the collective information obtained from various pages the user visited and worked with, i.e., the overall session state. To clear the concept, let us take an example of a shopping cart.
User adds items to a shopping cart. Items are selected from a page, say the items page, and the total collected items and price are shown on a different page, say the cart page. Only HTTP cannot keep track of all the information coming from various pages. ASP.NET session state and server side infrastructure keeps track of the information collected globally over a session.
The ASP.NET runtime carries the page state to and from the server across page requests while generating ASP.NET runtime codes, and incorporates the state of the server side components in hidden fields.











        Introduction To C# (C-Sharp) Programming
Microsoft introduced a new language called C# (pronounced C Sharp). C# is designed to be a simple, modern, general-purpose, object-oriented programming language, borrowing key concepts from several other languages, most notably Java. 
C# was developed by Anders Hejlsberg and his team during the development of .Net Framework.
C# is a part of .NET Framework.
Microsoft introduced C# as a new programming language to address the problems posed by traditional languages.
We can use C# for building variety of applications
•	WINDOWS APPLICATION: using console application or winform application.
•	MOBILE APPLICATIONS: for phones such as Nokia Lumia (built-in support) but we can use a third party tool or library called “XAMARIN” to create mobile applications for ANDROID and IOS as well.
•	WEB APPLICATON: using ASP.NET web forms or ASP.NET MVC.
•	GAMING APPLICATION: Unity.
C# could theoretically be compiled to machine code, but in real life, it's always used in combination with the .NET framework. Therefore, applications written in C#, requires the .NET framework to be installed on the computer running the application. While the .NET framework makes it possible to use a wide range of languages, C# is sometimes referred to as THE .NET language, perhaps because it was designed together with the framework.
Language interoperability is the ability of code to interact with code that is written by using a different programming language.
What is .Net Framework ?
•	.NET is a programming framework created by Microsoft that developers can use to create applications more easily. A framework is just a bunch of code that the programmer can call without having to write it explicitly.
•	It provides a controlled programming environment where software can be developed, installed and executed on Windows-based operating systems.
•	It is basically a collection of libraries.
•	Is a programming platform that is used for developing Windows, Web-based, and mobile software.
•	It has a number of pre-coded solutions that manage the execution of programs written specifically for the framework.
•	A programmer can develop applications using one of the languages supported by .NET.
•	Microsoft introduced C# as a new programming language to address the problems posed by traditional languages.
•	The .NET Framework is an infrastructure that is used to build, deploy, and run different types of applications and services using .NET technologies.
•	The .NET Framework is an infrastructure that is used to Minimize software development, deployment, and versioning conflicts.
Microsoft C# Was Developed To
•	Create a very simple and yet powerful tool for building interoperable and robust applications.
•	Create a complete object-oriented architecture.
•	Support powerful component-oriented development.
•	Allow access to many features previously available only in C++ while retaining the ease-of-use of a rapid application development tool such as Visual Basic.
•	Provide familiarity to programmers coming from C or C++ background.
•	Allow to write applications that target both desktop and mobile devices.
•	C# has features common to most object-oriented languages.
•	Provide consistent object-oriented programming environment.
•	Minimize software deployment and versioning conflicts by providing a code-execution environment.
•	Promote safe execution of code by providing a code-execution environment.
•	Provide a consistent developer experience across varying types of applications such as Windows-based applications and Web-based applications.
•	It has language-specific features, such as: 
o Type safety checking
o Generics
o Indexers
•	These features make the C# as a preferred language to create a wide variety of applications.
•	C# is a programming language designed for building a wide range of applications that run on the .NET Framework.
Purpose of C# Language
•	Microsoft .NET was formerly known as Next Generation Windows Services (NGWS).
•	It is a completely new platform for developing the next generation of Windows/Web applications.
•	These applications transcend device boundaries and fully harness the power of the Internet.
•	However, building the new platform required a language that could take full advantage.
•	This is one of the factors that led to the development of C#.
•	C# is an object-oriented language derived from C and C++.
•	The motive of C# is to provide a simple, efficient, productive, and object-oriented language that is familiar and yet at the same time revolutionary.
Features of C#
•	C# is a programming language designed for building a wide range of applications that run on the .NET Framework.
•	Following are some basic key features of C#:
o	Type-safety Checking
o	Object-oriented Programming
o	Garbage Collection
o	Standardization by European Computer Manufacturers Association (ECMA)
o	Generic Types and Methods
o	Iterators
o	Methods with named Arguments
o	Methods with optional Arguments
o	Static Classes
o	Nullable Types
o	Auto-implemented Properties
o	Accessor Accessibility
o	Anonymous Methods
o	Parallel Computing
o	Auto-implemented Properties
o	Partial Classes
•	Object-oriented Programming: Focuses on objects so that code written once can be reused. This helps reduce time and effort on the part of developers.
•	Type-safety Checking: Checked the overflow of types because uninitialized variables cannot be used in C# as C# is a case-sensitive language
•	Garbage Collection: Performs automatic memory management from time to time and spares the programmer the task.
•	Standardization by European Computer Manufacturers Association (ECMA): Specifies the syntax and constraints used to create standard C# programs.
•	Generic Types and Methods: Are a type of data structure that contains code that remains the same throughout but the data type of the parameters can change with each use.
•	Iterators: Enable looping (or iterations) on user-defined data types with the for each loop.
•	Static Classes: Contain only static members and do not require instantiation.
•	Partial Classes: Allow the user to split a single class into multiple source code (.cs) files.
•	Anonymous Methods: Enable the user to specify a small block of code within the delegate declaration.
•	Methods with named Arguments: Enable the user to associate a method argument with a name rather than its position in the argument list.
•	Methods with optional Arguments: Allow the user to define a method with an optional argument with a default value.
•	Nullable Types: Allow a variable to contain a value that is undefined.
•	Accessor Accessibility: Allows the user to specify the accessibility levels of the get and set accessors.
•	Auto-implemented Properties: Allow the user to create a property without explicitly providing the methods to get and set the value of the property.
•	Parallel Computing: Support for parallel programming using which develop efficient, fine-grained, and scalable parallel code without working directly with threads or the thread pool.
There are Several Applications Of C#
C# is an object-oriented language that can be used in a number of applications.
•	Gaming applications
•	Web applications
•	Mobile applications for pocket PCs, PDAs, and cell phones
•	Web services
•	Cloud applications
•	Simple standalone desktop applications such as Library Management Systems, Student Mark Sheet generation, and so on
•	Large-scale enterprise applications
•	Complex distributed applications that can spread over a number of cities or countries
The CLR
•	Is the foundation of the .NET Framework.
•	Acts as an execution engine for the .NET Framework.
•	Manages the execution of programs and provides a suitable environment for programs to run.
•	Provides a multi-language execution environment.
•	Is a backbone of .NET Framework
•	Performs various functions such as:
o	Memory management
o	Code execution
o	Error handling
o	Code safety verification
o	Garbage collection
By Using DotNet Framework
•	A programmer can develop applications using one of the languages supported by .NET.
•	These applications make use of the base class libraries provided by the .NET Framework.
•	The .NET Framework supports a number of development tools and language compilers in its Software Development Kit (SDK).
For Example
•	To display a text message on the screen, the following command can be used:
•	System.Console.WriteLine(".NET Architecture");
•	The same WriteLine() method will be used across all .NET languages.
•	This is done by making the Framework Class Library as a common class library for all .NET languages.
DotNet Framework Class Library (FCL)
•	Is a comprehensive object-oriented collection of reusable types.
•	Is used to develop applications ranging from traditional command-line to Graphical User Interface (GUI) applications that can be used on the Web.
DotNet Framework Components
•	Common Language Specification (CLS)
•	Common Type System (CTS)
•	Base Framework Classes
•	WPF
•	Asp.Net
•	WCF
•	Ado.Net
•	Entity Framework
•	Task Parallel Library
•	LINQ
•	Parallel LINQ
The .NET Framework languages, such as C#, VB, and J# are statically typed languages.
CLS - Common Language Specification
•	Is a set of rules that any .NET language should follow to create applications that are interoperable with other languages.
CTS - Common Type System
•	Describes how data types are declared, used, and managed in the runtime and facilitates the use of types across various languages.
ADO.NET
•	Provides classes to interact with databases.
ASP.Net
•	Provides a set of classes to build Web applications. ASP.NET Web applications can be built using Web Forms, which is a set of classes to design forms for the Web pages similar to the HTML.
•	Supports Web services that can be accessed using a standard set of protocols.
WCF
•	Is a service-oriented messaging framework.
•	Allows creating service endpoints and allows programs to asynchronously send and receive data from the service endpoint.
WPF
•	Is a UI framework based on XML and vector graphics.
•	Uses 3D computer graphics hardware and Direct3D technologies to create desktop applications with rich UI on the Windows platform.
LINQ
•	Is a component that provides data querying capabilities to a .NET application.
Entity Framework
•	Is a set of technologies built upon ADO.NET that enables creating data-centric applications in object-oriented manner. 
Parallel LINQ
•	Is a set of classes to support parallel programming using LINQ. 
Task Parallel Library
•	Is a library that simplifies parallel and concurrent programming in a .NET application.
When a code is executed for the first time
•	The CIL (COMMON INTERMEDIATE LANGUAGE) code is converted to a code native to the operating system.
•	This is done at runtime by the Just-In-Time (JIT) compiler present in the CLR.
•	The CLR converts the CIL code to the machine language code.
•	Once this is done, the code can be directly executed by the CPU.
 
The following figure represents the process of conversion of CIL code to the native code:
 
The CLR provides many features such as:
•	Memory management
•	Code execution
•	Error handling
•	Code safety verification
•	Garbage collection
The applications that run under the CLR are called managed code.
The CLR manages code at execution time and performs operations such as:
•	Thread management
•	Remoting
•	Memory management
Below figure shows a more detailed look at the working of the CLR:
 
CIL - Common Intermediate Language
•	Every .NET programming language generally has a compiler and a runtime environment of its own.
•	The compiler converts the source code into executable code that can be run by the users.
•	One of the primary goals of .NET Framework is to combine the runtime environments so that the developers can work with a single set of runtime services.
•	When the code written in a .NET compatible language such as C# or VB is compiled, the output code is in the form of MSIL code.
•	MSIL is composed of a specific set of instructions that indicate how the code should be executed.
•	MSIL is now called as Common Intermediate Language (CIL).
The following figure depicts the concept of CIL:
 
What Is Memory Management ?
•	In programming languages like C and C++, the allocation and de-allocation of memory is done manually.
•	Performing these tasks manually is both, time-consuming and difficult.
•	The C# language provides the feature of allocating and releasing memory using automatic memory management.
•	This means that there is no need to write code to allocate memory when objects are created or to release memory when objects are not required in the application.
•	Automatic memory management increases the code quality and enhances the performance and the productivity.
What Is Garbage Collection ?
•	Garbage Collection is the process of automatic reclaiming of memory from objects that are no longer in scope.
•	Garbage Collection helps the process of allocating and de-allocating memory using automatic memory management.
Below figure describes concept of garbage collection:
 
DLR - Dynamic Language Runtime
•	Is a runtime environment built on top of the CLR to enable interoperability of dynamic languages such as Ruby and Python with the .NET Framework.
•	Allows creating and porting dynamic languages to the .NET Framework.
•	Provides dynamic features to the existing statically typed languages. For example, C# relies on the DLR to perform dynamic binding.--%>



   <%--</pre>
        </p>--%>
</asp:Content>
