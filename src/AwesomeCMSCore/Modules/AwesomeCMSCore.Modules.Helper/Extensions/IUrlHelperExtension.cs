﻿namespace AwesomeCMSCore.Modules.Helper.Extensions
{
    public interface IUrlHelperExtension
    {
        string EmailConfirmationLink(string userId, string code, string scheme);
        string ResetPasswordCallbackLink(string userId, string code, string scheme);
    }
}
