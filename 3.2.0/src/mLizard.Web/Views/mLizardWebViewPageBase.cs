using Abp.Web.Mvc.Views;

namespace mLizard.Web.Views
{
    public abstract class mLizardWebViewPageBase : mLizardWebViewPageBase<dynamic>
    {

    }

    public abstract class mLizardWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected mLizardWebViewPageBase()
        {
            LocalizationSourceName = mLizardConsts.LocalizationSourceName;
        }
    }
}