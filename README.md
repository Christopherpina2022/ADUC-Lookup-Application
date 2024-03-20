# Active Directory Users and Computers (ADUC) Lookup Application
This C# application takes advantage of powershell's [RSAT](https://learn.microsoft.com/en-us/troubleshoot/windows-server/system-management-components/remote-server-administration-tools) tools
to allow users to lookup the global groups that a user has been assigned to by looking for the User's login name like they would when logging into their company computer. it can also look
for users within a Global Group as well. 

The user can define their own export path to create a place to save their file into a convenient CSV file so that it can be a quick reference for people needing to mirror access for a new hire,
as it is the intended purpose of this application.

## Domain Controller Documentation
This application requires that you know your Domain controller to look for users and Groups from Active Directory. You can edit the 
Domain controller via ADUCGroupCollection.cs on **Line 15 and 55** to satify your environment before use.

### How do i find my Domain Controller?
Method 1: Pinging Google
open CMD prompt and type the below command.

`nslookup google.com`

the second line after pressing enter (if you have a Domain Controller in your network) will return a server, which is your Domain Controller.

Method 2: Powershell with RSAT tools for AD

```
Import-Module ActiveDirectory
(Get-ADDomainController -DomainName <Domain FQDN> -Discover -NextClosestSite).HostName
```

You will need to have RSAT tools installed prior to running this via powershell, otherwise this method will not work.