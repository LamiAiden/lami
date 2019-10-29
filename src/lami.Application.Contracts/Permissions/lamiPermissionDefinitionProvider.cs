using lami.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace lami.Permissions
{
    public class lamiPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(lamiPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(lamiPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<lamiResource>(name);
        }
    }
}
