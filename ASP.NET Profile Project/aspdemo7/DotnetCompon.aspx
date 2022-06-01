<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DotnetCompon.aspx.cs" Inherits="aspdemo7.DotnetCompon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1 class="text-center">Dotnet Contains</h1>
    <div style="min-width:400px; max-width:1200px;font-size:18px; font-family:Arial;">
         

            <p style="font-size:18px; font-family:Arial; color:black; padding-left:80px;">


         <mark>.NET Components</mark> 
        The architecture of .Net framework is based on the following key components;
       1. Common Language Runtime
       The “Common Language Infrastructure” or CLI is a platform in .Net architecture
       on which the .Net programs are executed.<br />
       <br />
       The CLI has the following key features:<br />
       Exception Handling – Exceptions are errors which occur when the application<br />
       is executed.<br />
                <br />
       Examples of exceptions are:<br />
           If an application tries to open a file on the local machine, but the file is 
           not present.<br />
           If the application tries to fetch some records from a database, but the connection
           to the database is not valid.<br />
                <br />
        Garbage Collection – Garbage collection is the process of removing unwanted resources
        when they are no longer required.<br />
        Examples of garbage collection are<br />
	    A File handle which is no longer required. If the application has finished all operations 
        on a file, then the file handle may no longer be required.The database connection is no longer
        required. If the application has finished all operations on a database, then the database 
        connection may no longer be required.<br />
        Working with Various programming languages –<br />
                <br />
       As noted in an earlier section, a developer can develop an application in a 
       variety of .Net programming languages.<br />
                <br />
       Language – The first level is the programming language itself, the most common 
       ones are VB.Net and C#.<br />
                <br />
       Compiler – There is a compiler which will be separate for each programming language.
            So underlying the VB.Net language, there will be a separate VB.Net compiler.
            Similarly, for C#, you will have another compiler.<br />
                <br />
      Common Language Interpreter – This is the final layer in .Net which would be
            used to run a .net program developed in any programming language. So the subsequent
            compiler will send the program to the CLI layer to run the .Net application.<br />
                <br />

          <hmark>2. Class Library</hmark><br />
        The .NET Framework includes a set of standard class libraries. A class library is a 
        collection of methods and functions that can be used for the core purpose.
        For example, there is a class library with methods to handle all file-level operations.
        So there is a method which can be used to read the text from a file. Similarly,
        there is a method to write text to a file.<br />
                <br />
        Most of the methods are split into either the System.* or Microsoft.* namespaces.
        (The asterisk * just means a reference to all of the methods that fall under the System 
        or Microsoft namespace)
        A namespace is a logical separation of methods. We will learn these namespaces more in
        detail in the subsequent chapters.<br />
                <br />
         <mark>3. Languages</mark><br />
        The types of applications that can be built in the .Net framework is classified broadly
        into the following categories.<br />
                <br />
       WinForms – This is used for developing Forms-based applications, which would run on an
       end user machine. Notepad is an example of a client-based application.<br />
                <br />
      ASP.Net – This is used for developing web-based applications, which are made to run on
      any browser such as Internet Explorer, Chrome or Firefox. The Web application would be
      processed on a server, which would have Internet Information Services Installed. Internet
      Information Services or IIS is a Microsoft component which is used to execute an Asp.Net 
      application.<br />
	  The result of the execution is then sent to the client machines, and the output is shown 
      in the browser.<br />
                <br />
      ADO.Net – This technology is used to develop applications to interact with Databases 
      such as Oracle or Microsoft SQL Server. Microsoft always ensures that .Net frameworks are 
      in compliance with all the supported Windows operating systems.<br />
                <br />
      
          (1) Common Language Runtime or CLR<br />
                 It performs memory management, exception handling, debugging, security checking, thread execution,
                 code execution, code safety, verification, and compilation. The code that is directly managed by 
                 the CLR is called the managed code. When the managed code is compiled, the compiler converts the
                 source code into a CPU independent intermediate language (IL) code. A Just In Time(JIT) compiler
                 compiles the IL code into native code, which is CPU specific.<br />
                <br />
         (2) .Net Framework Class Library<br />
                 It contains a huge library of reusable types. classes, interfaces, structures, and enumerated 
                 values, which are collectively called types.<br />
                <br />
         (3) Common Language Specification<br />
                 It contains the specifications for the .Net supported languages and implementation of language
                 integration.<br />
                <br />
         (4) Common Type System      <br />
                 It provides guidelines for declaring, using, and managing types at runtime, and cross-language 
                 communication.<br />
                <br />
        (5) Metadata and Assemblies  <br />
                 Metadata is the binary information describing the program, which is either stored in a portable
                 executable file (PE) or in the memory. Assembly is a logical unit consisting of the assembly 
                 manifest, type metadata, IL code, and a set of resources like image files.<br />
                <br />
        (6) Windows Forms            <br />
                 Windows Forms contain the graphical representation of any window displayed in the application.
                <br />
        (7) ASP.NET and ASP.NET AJAX <br />
                 ASP.NET is the web development model and AJAX is an extension of ASP.NET for developing and 
                 implementing AJAX functionality. ASP.NET AJAX contains the components that allow the developer 
                 to update data on a website without a complete reload of the page.<br />
       

                <br />

                </p>
            </div>
        
</asp:Content>
