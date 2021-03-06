﻿using System.Web.Optimization;

namespace EventSourcingCqrsSample.WebApp
{
    /// <summary>
    /// This represents the config entity for bundles.
    /// </summary>
    public static class BundleConfig
    {
        /// <summary>
        /// Registers bundled JavaScripts and CSS files.
        /// </summary>
        /// <param name="bundles">The <see cref="BundleCollection" /> instance.</param>
        /// <remarks>For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862</remarks>
        public static void RegisterBundles(this BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-animate.min.js",
                        "~/Scripts/angular-route.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/site.css"));
        }
    }
}