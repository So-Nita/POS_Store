# Project_WindowForm

##Design POS using .Net7 With Project API

+ Project Structure

	- ** POS.DesignDemo (Presentation Layer): **
		_ Project responsible for designing the UI as a Windows Forms application.

	- ** POS.Library (Business Logic Layer): **
		_ Project containing business logic, including scaffolding and database interactions using EF Core with MySQL.

	- ** POS.Api (Data Access Layer): **
		_ API project serving as an interface to access business logic from the POS.Library.
		_ Handles requests from the presentation layer and interacts with the business logic in POS.Library.

##Architecture Overview

This project follows a three-tier architecture:

   1. ** Presentation Layer (UI): **
      - Designed in POS.UI

   2. ** Business Logic Layer: **
      - Implemented in POS.Library, handling business rules and database interactions.

   3. ** Data Access Layer (API): **
      - POS.Api serves as the API layer connecting the presentation layer to the business logic layer.
