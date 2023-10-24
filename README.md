## Welcome!

So you want to work for MultiTracks.com? This is a step in the right direction!


This repo contains a Class Library and a Web Forms Website project. As a member of the DotNET server team at MultiTracks.com you will most likely find yourself in similar projects on a regular basis. We have a number of projects also utilizing DotNetCore and all new projects in DotNet 7.


To get started:

- Clone the repo locally	
- Open the solution in Visual Studio	
- Run "Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r" from the Package Manager Console	
- Finally run the project for further instructions

## Multitracks Assesment 
### First things first! Go ahead and publish the DB and get the website connection string updated.
  - For this part I created a local DataBase in Sql Server, load the databese created in the project and Connected it with the project
  - ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/a7616c85-6ade-45e1-aeff-8466a11e96a9)
  - And Finally I got the Complete Assessment Page :)
  - ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/86e49803-ea3e-423a-accc-beba72292410)
### Now for the second point of the Assesment, I created ArtistDetails.aspx file with the markup from the project and Giving it all the connection with DB with the ArtistDetails.aspx.cs file
  - For this part we have to search with the ArtistId  url https://localhost[YOUR_PORT]/ArtistDetails.aspx?ArtistId=1, this is an example to get the page giving an ArtistId.
  ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/20f48bd3-36bc-499e-9cb8-bc711675cd05)
  ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/dc337bf1-7e79-4b93-a860-2ce0b3d531b7)
### API Documentation
- I Created 3 Endpoints
## Improves that we could implement in the project
- This project is made in a Monolithic Architecture, we could create a Microservices Architecture to improve this points:
  - Scalability
  - Modular Maintenance
  - Use of containers enabling rapid deployment and application development
  - Availability
  - Fast Changes
  - etc....
## Authors
  - Carlos Javier Orduz Trujillo
    




