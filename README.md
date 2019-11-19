# ABC.Template

This repository is a sample of [dotnet-templating](https://github.com/dotnet/templating).

## What does this sample want to do

While your work involves many *similar* solution items or projects, **creating a dotnet template** will be pretty useful.

The sample has two projects which mainly contains an `ITemplateLogService` and a `TemplateLogService`. If a similar solution is required to be created, for example, with an `IExceptionLogService` and an `ExceptionLogService`, I want to show you how to generate the solution in fast with dotnet-templating.

## Preparation

* .NET Core SDK, 3.0+

## Instruction

1. Clone this repository and copy the directory path. For example, in my computer it is '*G:\Code Repos\LeaFrock\ABC.Template\Source*';

2. Open the **CMD** of Windows, and `CD` into the directory;
![avatar](https://github.com/LeaFrock/ABC.Template/blob/master/ScreenShots/3.png)

3. Execute the command line, `dotnet new -i ./`. Then you'll see that the template is installed;
![avatar](https://github.com/LeaFrock/ABC.Template/blob/master/ScreenShots/4.png)

4. Create the directory which is the path of your new solution, such as '*G:\Code Repos\TemplateTest*'. And `CD` into it with **CMD**.

5. Execute the command line, `dotnet new abctpl -n Exception`. Then you'll see that new solution is created.
![avatar](https://github.com/LeaFrock/ABC.Template/blob/master/ScreenShots/6.png)

6. To uninstall the template, use the command line, `dotnet new -u <AbsolutePathOfTemplate>`. For me, it's `dotnet new -u "G:\Code Repos\LeaFrock\ABC.Template\Source"`.
