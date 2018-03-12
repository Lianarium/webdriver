﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.PageObjects;
using TestWebLibrary.Utils;
using TestWebProject;

namespace TestWebLibrary.Steps
{
    public abstract class BaseStep//here I can keep nav manager instance
    {
        protected LogInPage LoginPage = new LogInPage();
        protected HomePage  HomePage = new HomePage();
        protected ProjectsPage ProjectsPage = new ProjectsPage();
        protected NewProjectPage NewProjectPage = new NewProjectPage();
        protected IssuesPage IssuesPage = new IssuesPage();
        protected NewIssuePage NewIssuePage = new NewIssuePage();
        protected ActivityPage ActivityPage = new ActivityPage();
        public static NavigationManager  Navmanager = new NavigationManager();

        protected BaseStep()
        {

        }
    }
}
