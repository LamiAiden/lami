using Volo.Abp.Settings;

namespace lami.Settings
{
    public class lamiSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(lamiSettings.MySetting1));
        }
    }
}
