# CypherSafe Password Generator and Secure Login Storage App

A simple and secure password manager application that allows users to store and encrypt their login information. Built with C#, this application features AES encryption to allow secure storage of passwords on your device. The encryption keys for storing login information are based off a user set password for the application, meaning that anyone with unauthorized access
to your device would need your CypherSafe password to access your login information. Passwords are generated with crytographically secure RNG algorithms, meaning no one will be able to recreate your generated password. This project was done as a side project by a university student, so there may be some bugs.

## Features

- **Secure Password Storage**: Encrypts and stores user login information.
- **Password Generation**: Generate strong passwords for your accounts.
- **Data Protection**: Utilizes AES encryption for secure local storage. 

## Technologies Used

- C# .NET 6.0
- Windows Forms
- AES Encryption
- GitHub for version control

## Getting Started

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (version 6.0)
- Visual Studio or another compatible IDE

### Installation

This repository contains the compiled application in bin/Debug/net6.0-windows. To run it, you can simply clone the repository to your PC and run the executable. If you're weary of running executables from random people on github (which you should be!!), the .sln and all source code files are included this repo. You can simply review these 
and build the application for yourself. 

### Usage

Upon opening the application, you'll be asked to set your password. It is very important that you choose a secure password, and store that password in a secure place. This password is necessary to access any saved login information in the app, this password is also used to generate encryption/decryption keys for storage of login information,
so you don't want someone else to get their hands on it. From there you'll be asked to login, use the password you set and continue to the main application. 

### Contributing 

Contributions are welcome! If you have suggestions for improvements or new features, please create an issue or submit a pull request.


### License

This project is licensed under the Creative Commons non-Commerical License

Creative Commons Attribution-NonCommercial 4.0 International License

You are free to:
- Share — copy and redistribute the material in any medium or format
- Adapt — remix, transform, and build upon the material

The licensor cannot revoke these freedoms as long as you follow the license terms.

Under the following terms:
- Attribution — You must give appropriate credit, provide a link to the license, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.
- NonCommercial — You may not use the material for commercial purposes.

No additional restrictions — You may not apply legal terms or technological measures that legally restrict others from doing anything the license permits.

For a more detailed overview, go to https://creativecommons.org/licenses/by-nc/4.0/deed.en 


