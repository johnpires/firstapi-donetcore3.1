# Running this project ASP.NET Core API Locally

1. Download or clone the tutorial project code from https://github.com/johnpires/firstapi-donetcore3.1 <br/><br/>
2. Start the api by running dotnet run from the command line in the project root folder (where the ApiCore-JWTAuthentication.csproj file is located), you should see the message Now listening on: http://localhost:4000. Follow the instructions below to test with Postman or hook up with one of the example single page applications available (Angular, React or Vue).


**## Testing the ASP.NET Core JWT Auth API with Postman**
<br><br>
Postman is a great tool for testing APIs, you can download it at [Postman](https://www.getpostman.com/).
<br>

Below are instructions on how to use Postman to authenticate a user to get a JWT token from the api, and then make an authenticated request with the JWT token to retrieve a list of users from the api.
<br><br>

**## How to authenticate a user with Postman**
<br><br>
**To authenticate a user with the api and get a JWT token follow these steps:**
<br>
    * Open a new request tab by clicking the plus (+) button at the end of the tabs.<br>
    * Change the http request method to "POST" with the dropdown selector on the left of the URL input field.<br>
    * In the URL field enter the address to the authenticate route of your local API - http://localhost:4000/users/authenticate.<br>
    * Select the "Body" tab below the URL field, change the body type radio button to "raw", and change the format dropdown selector to "JSON (application/json)".<br>
    * Enter a JSON object containing the test username and password in the "Body" textarea:

        {
            "username": "johnpires",
            "password": "password"
        }

    * Click the "Send" button, you should receive a "200 OK" response with the user details including a JWT token in the response body, make a copy of the token value because we'll be using it in the next step to make an authenticated request.

Here's a screenshot of Postman after the request is sent and the user has been authenticated:
<br>
![Authenticate](https://user-images.githubusercontent.com/26515702/82599672-b3053600-9b7a-11ea-8c6f-4d851a6372d8.png)
<br>

**## How to make an authenticated request to retrieve all users**
<br><br>
To make an authenticated request using the JWT token from the previous step, follow these steps:

    * Open a new request tab by clicking the plus (+) button at the end of the tabs.
    * Change the http request method to "GET" with the dropdown selector on the left of the URL input field.
    * In the URL field enter the address to the users route of your local API - http://localhost:4000/users.
    * Select the "Authorization" tab below the URL field, change the type to "Bearer Token" in the type dropdown selector, and paste the JWT token from the previous authenticate step into the "Token" field.
    * Click the "Send" button, you should receive a "200 OK" response containing a JSON array with all the user records in the system (just the one test user in the example).

Here's a screenshot of Postman after making an authenticated request to get all users:
<br>
![Authenticated](https://user-images.githubusercontent.com/26515702/82600091-535b5a80-9b7b-11ea-86d4-56ba40841b3f.png)
