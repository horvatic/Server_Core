﻿using System;

namespace Server.Core
{
    public interface IWebPageMaker
    {
        string OutPutNames(string firstName, string lastName);
        string Error404Page();
        string HelloWorld();
        string DirectoryContents(string dir, IDirectoryProxy reader, string root);
        string NameForm();
    }
}