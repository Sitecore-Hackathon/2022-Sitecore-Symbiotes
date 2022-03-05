# Hackathon Submission Entry form

> __Important__  
> 
> Copy and paste the content of this file into README.md or face automatic __disqualification__  
> All headlines and subheadlines shall be retained if not noted otherwise.  
> Fill in text in each section as instructed and then delete the existing text, including this blockquote.

You can find a very good reference to Github flavoured markdown reference in [this cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet). If you want something a bit more WYSIWYG for editing then could use [StackEdit](https://stackedit.io/app) which provides a more user friendly interface for generating the Markdown code. Those of you who are [VS Code fans](https://code.visualstudio.com/docs/languages/markdown#_markdown-preview) can edit/preview directly in that interface too.

## Team name
⟹ Sitecore Symbiotes

## Category
⟹ Category # 3: Best addition to the Sitecore MVP site

## Description
⟹ Integrate Sitecore.stackExchange.com to show the users in the MVP site to add "connect to experts" feature

  - The purpose is to facilitate users to have sitecore.stackExchange.com experts in the MVP website.
  - This will allow users to directly access sitecore experts questions and anwers from one place.
    
_You can alternately paste a [link here](#docs) to a document within this repo containing the description._

## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)



## Pre-requisites and Dependencies

- Sitecore 10.2
- .NET Core (>= v 3.1)
- .NET Framework 4.8
- Okta Developer Account
- Valid Sitecore license

_Remove this subsection if your entry does not have any prerequisites other than Sitecore_

## Installation instructions
> Before you can run the solution, you will need to prepare the following for the Sitecore container environment:

A valid/trusted wildcard certificate for *.sc.localhost

Hosts file entries for

- mvp-cd.sc.localhost
- mvp-cm.sc.localhost
- mvp-id.sc.localhost
- mvp.sc.localhost
 
Required environment variable values in .env for the Sitecore instance

(Can be done once, then checked into source control.)
See Sitecore Containers documentation for more information on these preparation steps. The provided init.ps1 will take care of them, but you should review its contents before running.

You must use an elevated/Administrator Windows PowerShell 5.1 prompt for this command, PowerShell 7 is not supported at this time.

.\init.ps1 -InitEnv -LicenseXmlPath "C:\path\to\license.xml" -AdminPassword "DesiredAdminPassword"
At the bottom of the .env file you'll find the section for your Okta developer account details. You will need to populate the following values:

- OKTA_DOMAIN (must include protocol, e.g. OKTA_DOMAIN=https://dev-your-id.okta.com)
- OKTA_CLIENT_ID
- OKTA_CLIENT_SECRET
Note that DOCKER_RESTART defaults to no but can point to always or other values as per this page - https://docs.docker.com/config/containers/start-containers-automatically/

After completing this environment preparation, run the startup script from the solution root: ps1 .\up.ps1 Note that the up.ps1 script now automatically detects:
if running Docker linux daemon and switches to Windows
and stops IIS if it is running in the machine
When prompted, log into Sitecore via your browser, and accept the device authorization.

Wait for the startup script to open browser tabs for the rendered site and Sitecore Launchpad.


![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")

