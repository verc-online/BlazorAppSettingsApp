﻿namespace BlazorAppSettingsApp.Options
{
    public class EmailSettingsOptions
    {
        public bool EnableEmailSystem { get; set; }
        public int EmailTimeoutInSeconds { get; set; }
        public List<string> EmailServers { get; set; } = new();
        public AdminOptions EmailAdmin { get; set; } = new();
    }
}
