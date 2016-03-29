using System.Collections.Generic;

namespace Tomaltach.MechanicsJournal.Entity.Statics
{
    // Static class instead of an enum because attributes (namely Authorize) only accepts consts.
    public static class UserRoles
    {
        /// <summary>
        /// This is used throughout the application as an enum/lookup to imply an invalid user id and to perform all the security checks.
        /// </summary>
        public const int InvalidUserId = -1;

        /// <summary>
        /// This is used throughout the application as an enum/lookup to distinguish GroupAdmin users and to perform all the security checks.
        /// </summary>
        public const int ClientAdminMockId = -2;

        public const string Root = "Root";
        public const int RootId = 1;

        public const string UserManager = "UserManager";
        public const int UserManagerId = 2;

        public const string ChangeLogViewer = "ChangeLogViewer";
        public const int ChangeLogViewerId = 3;

        public const string AlertManager = "AlertManager";
        public const int AlertManagerId = 4;

        public static IDictionary<int, string> All = new Dictionary<int, string>
        {
            { RootId, Root },
            { UserManagerId, UserManager},
            { ChangeLogViewerId, ChangeLogViewer },
            { AlertManagerId, AlertManager }
        };
    }
}
