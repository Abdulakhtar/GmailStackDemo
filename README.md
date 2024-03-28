# GmailStackDemo

Welcome to GmailStackDemo! This is a sample ASP.NET Core web application that demonstrates how to fetch emails from a Gmail account using the IMAP protocol and display them on a web page.

## Getting Started

To get started with this project, follow these steps:

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) or you can download latest .NET 7 (current)
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/) (optional)

### Installation

1. Clone this repository to your local machine:

      ````git clone https://github.com/your-username/GmailStackDemo.git````

or just clone by downloading the folder.

2. Navigate to the project directory:

      ````cd GmailStackDemo````

3. Install the required packages using the .NET CLI:

      ````dotnet restore````

Once, you have installed all of the packages, and your visual studio or code is ready, do following steps:

### Configuration
1. Open the _MailRepository.cs_ file located in the Services directory.

2. Replace the following placeholders with your Gmail email address and password:

      ````
      string login = "yourEmailAddress@gmail.com";
      string password = "yourPassword";
      ````

### Running the Application

You can run the application using the .NET CLI. Navigate to the project directory and execute the following command:

      dotnet run

OR

you can simply run by hitting F5 on the keyboard or the green play button just underneath the tools in VS Studio. 
Once the application is running, open your web browser and navigate to https://localhost:5001 or whatever your port is, to view the emails fetched from your Gmail account.

### Additional Notes

1. Ensure that IMAP access is enabled for your Gmail account. In most of the cases or by default it is enabled. If not, you can enable it in your Gmail settings.
2. This project uses the MailKit library for interacting with the IMAP server. No additional authentication or authorization steps are required within the application.
3. If you insert your email and passwrd in MailRepository.cs file and it displays and error for incorrect credentials, then you might need to enable 2-Factor Authetication from your Google account.
  Please refer to the link: https://support.google.com/accounts/answer/185839
4. After enabling Two-Factor Authentication (2FA) for your Google account, you might be prompted to generate an "App Password" to use with applications that do not support 2FA directly, such as certain email clients or services.
  Here's how you can generate an App Password for your Google account:

    i.  Go to your Google Account settings: https://myaccount.google.com/security.
   
    ii.  Under "Signing in to Google," select "App passwords." You may need to sign in again to proceed.
   
    iii.  If prompted, enter your Google account password again for verification.
   
    iv.  In the "App passwords" section, select the app and device you want to generate the app password for. If the specific app or device is not listed, choose "Other (Custom name)".
   
    v.  Click "Generate." Google will generate a unique app password for the selected app and device.
   
   
6. Once you've generated the app password, you can use it in place of your regular Google account password in the code in MailRepositoery.cs, when setting up or signing in to applications that do not support 2FA directly. This helps maintain the security of your Google account while still allowing access to these applications.

### Contributing

If you'd like to contribute to this project, feel free to fork the repository and submit a pull request with your changes in a new branch.

### License

This project is licensed under the MIT License - see the LICENSE file for details.

### NOTE:

Feel free to customize this README file further to suit your project's specific requirements or add any additional information you find necessary.
