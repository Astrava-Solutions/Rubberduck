using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rubberduck.Parsing.VBA;
using Rubberduck.Refactorings.ImplementInterface;
using Rubberduck.VBEditor;
using Rubberduck.VBEditor.Application;
using Rubberduck.VBEditor.Events;
using Rubberduck.VBEditor.SafeComWrappers;
using RubberduckTests.Mocks;

namespace RubberduckTests.Refactoring
{
    [TestClass]
    public class ImplementInterfaceTests
    {
        [TestMethod]
        public void ImplementInterface_Procedure()
        {
            //Input
            const string inputCode1 =
@"Public Sub Foo()
End Sub";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Sub Class1_Foo()
    Err.Raise 5 'TODO implement interface member
End Sub
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_Procedure_ClassHasOtherProcedure()
        {
            //Input
            const string inputCode1 =
@"Public Sub Foo()
End Sub";

            const string inputCode2 =
@"Implements Class1
Public Sub Bar()
End Sub";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Sub Class1_Foo()
    Err.Raise 5 'TODO implement interface member
End Sub

Public Sub Bar()
End Sub";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_Procedure_WithParams()
        {
            //Input
            const string inputCode1 =
@"Public Sub Foo(ByVal a As Integer, ByRef b, c, d As Long)
End Sub";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Sub Class1_Foo(ByVal a As Integer, ByRef b As Variant, ByRef c As Variant, ByRef d As Long)
    Err.Raise 5 'TODO implement interface member
End Sub
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_Function()
        {
            //Input
            const string inputCode1 =
@"Public Function Foo() As Integer
End Function";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Function Class1_Foo() As Integer
    Err.Raise 5 'TODO implement interface member
End Function
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_Function_WithImplicitType()
        {
            //Input
            const string inputCode1 =
@"Public Function Foo()
End Function";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Function Class1_Foo() As Variant
    Err.Raise 5 'TODO implement interface member
End Function
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_Function_WithParam()
        {
            //Input
            const string inputCode1 =
@"Public Function Foo(a)
End Function";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Function Class1_Foo(ByRef a As Variant) As Variant
    Err.Raise 5 'TODO implement interface member
End Function
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_PropertyGet()
        {
            //Input
            const string inputCode1 =
@"Public Property Get Foo() As Integer
End Property";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Property Get Class1_Foo() As Integer
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_PropertyGet_WithImplicitType()
        {
            //Input
            const string inputCode1 =
@"Public Property Get Foo()
End Property";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Property Get Class1_Foo() As Variant
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_PropertyGet_WithParam()
        {
            //Input
            const string inputCode1 =
@"Public Property Get Foo(a)
End Property";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Property Get Class1_Foo(ByRef a As Variant) As Variant
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_PropertyLet()
        {
            //Input
            const string inputCode1 =
@"Public Property Let Foo(ByRef value As Long)
End Property";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Property Let Class1_Foo(ByRef value As Long)
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_PropertyLet_WithParam()
        {
            //Input
            const string inputCode1 =
@"Public Property Let Foo(a)
End Property";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Property Let Class1_Foo(ByRef a As Variant)
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_PropertySet()
        {
            //Input
            const string inputCode1 =
@"Public Property Set Foo(ByRef value As Variant)
End Property";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Property Set Class1_Foo(ByRef value As Variant)
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_PropertySet_WithParam()
        {
            //Input
            const string inputCode1 =
@"Public Property Set Foo(a)
End Property";

            const string inputCode2 =
@"Implements Class1";

            var selection = new Selection(1, 1, 1, 1);

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Property Set Class1_Foo(ByRef a As Variant)
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementInterface_PropertySet_AllTypes()
        {
            //Input
            const string inputCode1 =
@"Public Sub Foo()
End Sub

Public Function Bar(ByVal a As Integer) As Boolean
End Function

Public Property Get Buz(ByVal a As Boolean) As Integer
End Property

Public Property Let Buz(ByVal a As Boolean, ByRef value As Integer)
End Property";

            const string inputCode2 =
@"Implements Class1";

            var selection = Selection.Home;

            //Expectation
            const string expectedCode =
@"Implements Class1

Private Sub Class1_Foo()
    Err.Raise 5 'TODO implement interface member
End Sub

Private Function Class1_Bar(ByVal a As Integer) As Boolean
    Err.Raise 5 'TODO implement interface member
End Function

Private Property Get Class1_Buz(ByVal a As Boolean) As Integer
    Err.Raise 5 'TODO implement interface member
End Property

Private Property Let Class1_Buz(ByVal a As Boolean, ByRef value As Integer)
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode1)
                 .AddComponent("Class2", ComponentType.ClassModule, inputCode2)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), selection);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void CreatesMethodStubForAllProcedureKinds()
        {
            //Input
            const string interfaceCode =
@"Public Sub Foo(ByVal arg1 As Integer, ByVal arg2 As String)
End Sub

Public Function Fizz(b)
End Function

Public Property Get Buzz() As Variant
End Property

Public Property Let Buzz(value)
End Property

Public Property Set Buzz(value)
End Property";

            const string inputCode =
@"Implements IClassModule";

            //Expectation
            const string expectedCode =
@"Implements IClassModule

Private Sub IClassModule_Foo(ByVal arg1 As Integer, ByVal arg2 As String)
    Err.Raise 5 'TODO implement interface member
End Sub

Private Function IClassModule_Fizz(ByRef b As Variant) As Variant
    Err.Raise 5 'TODO implement interface member
End Function

Private Property Get IClassModule_Buzz() As Variant
    Err.Raise 5 'TODO implement interface member
End Property

Private Property Let IClassModule_Buzz(ByRef value As Variant)
    Err.Raise 5 'TODO implement interface member
End Property

Private Property Set IClassModule_Buzz(ByRef value As Variant)
    Err.Raise 5 'TODO implement interface member
End Property
";

            //Arrange
            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("TestProject1", ProjectProtection.Unprotected)
                 .AddComponent("IClassModule", ComponentType.ClassModule, interfaceCode)
                 .AddComponent("Class1", ComponentType.ClassModule, inputCode)
                 .Build();
            var vbe = builder.AddProject(project).Build();
            var component = project.Object.VBComponents[1];

            var mockHost = new Mock<IHostApplication>();
            mockHost.SetupAllProperties();
            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), Selection.Home);
            var module = project.Object.VBComponents[1].CodeModule;

            //Act
            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            //Assert
            Assert.AreEqual(expectedCode, module.Content());
        }

        [TestMethod]
        public void ImplementsInterfaceInDocumentModule()
        {
            const string interfaceCode = @"Option Explicit
Public Sub DoSomething()
End Sub
";
            const string initialCode = @"Implements IInterface";
            const string expectedCode = @"Implements IInterface

Private Sub IInterface_DoSomething()
    Err.Raise 5 'TODO implement interface member
End Sub
";
            var selection = Selection.Home;
            var vbe = new MockVbeBuilder()
                .ProjectBuilder("TestProject", ProjectProtection.Unprotected)
                .AddComponent("IInterface", ComponentType.ClassModule, interfaceCode)
                .AddComponent("Sheet1", ComponentType.Document, initialCode, selection)
                .MockVbeBuilder()
                .Build();

            var project = vbe.Object.VBProjects[0];
            var component = project.VBComponents["Sheet1"];

            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));
            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), Selection.Home);
            var module = component.CodeModule;

            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            Assert.AreEqual(expectedCode, module.Content());
        }
 
            [TestMethod]
        public void ImplementsInterfaceInUserFormModule()
        {
            const string interfaceCode = @"Option Explicit
Public Sub DoSomething()
End Sub
";
            const string initialCode = @"Implements IInterface";
            const string expectedCode = @"Implements IInterface

Private Sub IInterface_DoSomething()
    Err.Raise 5 'TODO implement interface member
End Sub
";
            var selection = Selection.Home;
            var vbe = new MockVbeBuilder()
                .ProjectBuilder("TestProject", ProjectProtection.Unprotected)
                .AddComponent("IInterface", ComponentType.ClassModule, interfaceCode)
                .AddComponent("Form1", ComponentType.UserForm, initialCode, selection)
                .MockVbeBuilder()
                .Build();

            var project = vbe.Object.VBProjects[0];
            var component = project.VBComponents["Form1"];

            var parser = MockParser.Create(vbe.Object, new RubberduckParserState(vbe.Object));
            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var qualifiedSelection = new QualifiedSelection(new QualifiedModuleName(component), Selection.Home);
            var module = component.CodeModule;

            var refactoring = new ImplementInterfaceRefactoring(vbe.Object, parser.State, null);
            refactoring.Refactor(qualifiedSelection);

            Assert.AreEqual(expectedCode, module.Content());
        }
    }
}

