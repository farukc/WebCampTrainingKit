﻿using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeekQuiz.Startup))]

namespace GeekQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {         
            this.ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
