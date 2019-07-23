# Explorer App Project
This repository holds the code for the Explorer App project, aka Learnmore.be built during oSoc19. It consists of two directories, one holding the frontend code and one holding the backend code.

It's an interface for tourists to learn more on Brugge's artworks while getting at the same time insights on their preferences.

## Running the project
#### Backend 

- Add your database credentials in a file called ```secret.json``` and that has to in the ```backend/``` folder like this : 
```
{
  "server":"YOUR_SERVER_IP",
  "database":"YOUR_DATABASE_NAME",
  "user":"YOUR_USERNAME",
  "password":"YOUR_PASSWORD"
}
```
- `cd backend/`
- To run the API without docker : `dotnet run` -> localhost:5001/
- To run the API with docker : `docker build -t backend .` then `docker run -d -p 8080:80 --name explorerapp backend` -> localhost:8080/

###### API endpoints : 
- /swagger : full API documentation
- /api/painting : list of all paintings
- /api/painting/[id]?language=[LANGUAGE_CODE] : one specific painting in a specific language
- /api/artist : list of all artists
- /api/artist/[id] : one specific artist
- /api/movement : list of all movements
- /api/movement/[id] : one specific movement
- /api/technique : list of all techniques
- /api/technique/[id] : one specific technique
- /api/language : list of all languages
- /api/language/[id] : one specific language
- /api/paintingAudio : list of all painting's audios
- /api/paintingAudio/[id] : one specific audio
- /api/paintingStory : list of all painting's stories
- /api/paintingStory/[id] : one specific story

#### Frontend

#### Data Sources
https://en.wikipedia.org
https://vkc-barok-prod.inuits.eu/en
