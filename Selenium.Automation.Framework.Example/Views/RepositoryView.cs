﻿using OpenQA.Selenium;

namespace Selenium.Automation.Framework.Example.Views
{
    public class RepositoryView : View
    {
        public Element Description
        {
            get { return FindElement(By.ClassName("js-current-repository")); }
        }

        protected override By BaseBy
        {
            get { return By.ClassName("repohead"); }
        }
    }
}
