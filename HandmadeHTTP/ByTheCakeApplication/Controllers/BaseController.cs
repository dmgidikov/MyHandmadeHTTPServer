﻿namespace HandmadeHTTP.ByTheCake.Controllers
{
    using Infrastructure;

    public abstract class BaseController : Controller
    {
        protected override string ApplicationDirectory => "ByTheCakeApplication";
    }
}

