﻿using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Localization;
using Abp.Threading;
using sessionliang_M_EF.Web.Models.Layout;

namespace sessionliang_M_EF.Web.Controllers
{
    public class LayoutController : sessionliang_M_EFControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ILocalizationManager _localizationManager;

        public LayoutController(IUserNavigationManager userNavigationManager, ILocalizationManager localizationManager)
        {
            _userNavigationManager = userNavigationManager;
            _localizationManager = localizationManager;
        }

        [ChildActionOnly]
        public PartialViewResult TopMenu(string activeMenu = "")
        {
            var model = new TopMenuViewModel
                        {
                            MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", CurrentSession.UserId)),
                            ActiveMenuItemName = activeMenu
                        };

            return PartialView("_TopMenu", model);
        }

        [ChildActionOnly]
        public PartialViewResult LanguageSelection()
        {
            var model = new LanguageSelectionViewModel
                        {
                            CurrentLanguage = _localizationManager.CurrentLanguage,
                            Languages = _localizationManager.GetAllLanguages()
                        };

            return PartialView("_LanguageSelection", model);
        }
    }
}