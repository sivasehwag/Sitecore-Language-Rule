// <copyright file="LanguageNameCondition.cs">
// Copyright (c) 2019
// </copyright>
// <author>DEWA\sivakumar.r</author>

namespace SitecoreLanguageRule
{
    using Sitecore.Diagnostics;
    using Sitecore.Globalization;

    /// <summary>
    /// Defines the <see cref="LanguageNameCondition{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LanguageNameCondition<T> : Sitecore.Rules.Conditions.StringOperatorCondition<T> where T : Sitecore.Rules.RuleContext
    {
        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The Execute
        /// </summary>
        /// <param name="ruleContext">The ruleContext<see cref="T"/></param>
        /// <returns>The <see cref="bool"/></returns>
        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            string value = this.Value;
            if (value == null)
                return false;
            Language Language = Sitecore.Context.Language;
            if (Language == null)
                return false;
            return Compare(Language.Name, value);
        }
    }
}
