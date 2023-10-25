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
#### Project Structure
  This project was made with Clean Architecture Structure, defining 3 principal layers(Application, Domain and Infrastructure) for each model controller
  ##### Artist
    - Application
    - Domain
    - Infrastructure
  ##### Song
    - Application
    - Domain
    - Infrastructure
  ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/dc5c1134-6293-4e30-a816-19ab5192b989)

#### Artist Controller
  - Endpoint to Search for an artist by name (GET)
    You have to make a GET petition to this url https://localhost:[YOUR_OPEN_PORT]/api/artist?ArtistName=[ARTIST_NAME]
    Example Request:
    ```
      https://localhost:[YOUR_OPEN_PORT]/api/artist?ArtistName=Marcos%20Witt
    ```
    ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/cb5ac663-610e-422e-ab09-85e2d2b7285c)
    ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/18b2cd66-0264-49ca-aa74-349ac49916b5)


  - Endpoint to add an Artist to the Artist Table (POST)
    You have to make a POST petition to this URL: https://localhost:[YOUR_OPEN_PORT]/api/artist , with this example Body in the Rquest:
    ```
      {
        "title": "Marcos Witt",
        "imageURL": "https://mtracks.azureedge.net/public/images/artists/cover/512/257.jpg",
        "heroURL": "https://mtracks.azureedge.net/public/images/artists/hero/2420/257.jpg",
        "biography": "Marcos Witt es reconocido como músico, cantante y compositor. Es originario de San Antonio, Texas. Creció en Durango, México, como hijo de misioneros, en donde realizó sus estudios básicos y sus primeros estudios musicales. Es considerado uno de los pioneros de la música cristiana en español y también uno de los más queridos promotores de este género, representando a la música cristiana en América Latina y llevando a cabo conciertos masivos en muchos países. Cuenta con 43 álbumes, 10 DVD, 9 singles y varios millones de copias de sus álbumes vendidas en todo el mundo. Ha sido galardonado con cinco Latin GRAMMY® y dos Premios Billboard, recibiendo muchas otras nominaciones y reconocimientos. Sus presentaciones convocan a multitudes en los principales foros de América Latina, algunas ante un público superior a las 80,000 personas. Marcos se convirtió en una de las figuras más influyentes en la historia del cristianismo en América Latina, no solo como cantante y compositor, sino también como conferencista, autor, pensador y líder de opinión para la comunidad latinoamericana en general. Hoy en día, Marcos viaja alrededor del mundo para capacitar y ayudar a otros a lograr su máximo potencial a través de valores y principios sanos, reales y aplicables. Su deseo es ser conocido como alguien que impulsa y promueve a otros. Actualmente reside en Houston, Texas, con su esposa, Miriam. Tienen cuatro hijos: Elena, Jonathan, Kristofer y Carlos, y dos nietos: Krystal y Marcos."
      }
    ```
    ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/fbb50d76-90fc-4b3d-acdf-0ec8ef5ca64f)
    ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/85155354-029f-4fc7-a348-4cb15357a525)


#### Song Controller
  - Endpoint to list all Songs with paging support using page size, page number, etc. (GET)
    You have to make a GET petition to this URL: https://localhost:[YOUR_OPEN_PORT]/api/song?PageSize=25&Page=1
    Example Request:
    ```
      https://localhost:[YOUR_OPEN_PORT]/api/song?PageSize=25&Page=1
    ```
    
    ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/c6d4240c-5335-4483-b35c-d7050f2f08c7)
    ![image](https://github.com/CarlosOrduz777/MultiTracksAssessment/assets/69254834/e66c7308-d3a8-4c27-a34d-2b05767c6c96)
    In this case we have a total of 100 recorded songs, so the number of pages are 4 and we are currently in the page 1:
    "paginationInfo":{"Pages":4,"TotalRecords":100,"CurrentPage":1,"RecordsPerPage":25} 
    


    
## Improves that we could implement in the project
- This project is made in a Monolithic Architecture, we could create a Microservices Architecture to improve this points:
  - Scalability
  - Modular Maintenance
  - Use of containers enabling rapid deployment and application development
  - Availability
  - Fast Changes
  - etc....
## Authors
  - Carlos Javier Orduz Trujillo - Software Engineer
  - Colombia




