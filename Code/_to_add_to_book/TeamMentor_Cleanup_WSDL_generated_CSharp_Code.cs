//var topPanel = "{name}".popupWindow(700,400);
var file = @"E:\TeamMentor\TM_Dev Repos\TM_DEV\Web Applications\TeamMentor.UnitTests.TM_Website\Web References\WebServices\Reference.cs";
//return file.ast();
var astData = file.getAstData(false);
var compilationUnit = astData.compilationUnits().first();

return compilationUnit.types(true).iNodes();
var methodsToRemove = compilationUnit.methods().where((method)=> method.Name.contains("Async", "Completed"));
foreach(var methodToRemove in methodsToRemove)  
    methodToRemove.Parent.Children.Remove(methodToRemove);

var typesToRemove = compilationUnit.types(true).where((type)=> type.Name.contains("EventArgs"));
foreach(var typeToRemove in typesToRemove)
    typeToRemove.Parent.Children.Remove(typeToRemove);
    
var codeEditor      = panel.clear().add_SourceCodeEditor();
var csharpCode      = compilationUnit.csharpCode();

codeEditor.set_Text(csharpCode,".cs");

//FluentSharp.CSharpAST;
//using FluentSharp.CSharpAST.Utils
//using FluentSharp.CSharpAST
//O2Ref:FluentSharp.REPL.exe