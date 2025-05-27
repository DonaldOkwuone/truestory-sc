
# Project Title

Truestory Assisgnment: Api extending endpoints on (https://api.restful-api.dev/objects)


## Installation

Install my-project with npm

```bash
    dotnet build
    dotnet run --project Truestory
```
The API will be available at: https://localhost:<port>/api/message
    
## Project Structure

Truestory/
├── Controllers/
│ └── MessageController.cs
├── Middleware/
│ ├── ExceptionHandlingMiddleware.cs
├── Model/
│ ├── dto/
│ │ ├── AddGadgetDto.cs
│ │ ├── DeleteGadgetRequestDto.cs
│ └── pagination/
│ └── GadgetRequestParam.cs
├── Repositories/
│ ├── Implementations/
│ ├──├──GadgetRepo.cs
│ ├──IGadgetRepo.cs
├── Services/
│ └── IGadgetService.cs
## Available endpoints

## Add Message

POST /api/message/addMessage

Adds a new gadget/message.
Request Body (AddGadgetDto)


{
  "name": "Sample Gadget",
  "description": "A cool gadget",
  "price": 199.99
}

## Response:

{
  "isSuccess": true,
  "data": { ... },
  "message": "Gadget added successfully"
}


## Fetch Records

GET /api/message/fetchRecords

Fetches gadgets with pagination and mandatory filters.
Query Parameters (GadgetRequestParam)

    pageNumber: integer

    pageSize: integer

    searchTerm: string (mandatory)

## Delete Records

GET /api/message/DeleteRecords

Fetches gadgets with pagination and mandatory filters.
Query Parameters (GadgetRequestParam)

    Id: string

## Exception Handling
Exceptions are handled by the middleware with the standard response:

  var response = new
  {
      success = false,
      error = "An error occurred while processing your request.",
      detail = ex.Message
  };