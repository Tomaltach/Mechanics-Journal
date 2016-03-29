using System;
using System.Reflection;

namespace Tomaltach.MechanicsJournal.API.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}