# Test Result
## Task 1: What does the UI look like on mobile devices?
- Left Sidebar:
  + Replace text with icons. When hovering over each icon, display a tooltip with the corresponding text.
  + Add a collapsible/expandable button for the left sidebar.

- Header Bar - Welcome Peldi, History: 
  + Depending on the responsive of the screen: we can display the button with text, but if used on mobile we should display it as a dropdown list 

- Header Bar - Search Button:
  + In mobile view, only display the search icon. When clicked, show the search input.
  + In other views, always show the search input.

- Bottom Buttons (e.g., show children, view in hierarchy, etc.):
  + Replace text wsith icons, and add a tooltip with the corresponding text.
     
## Task 2
I use a public API to get a list of categories (id, name) (header required x-api-key)

### Back-end:
- Create an API to retrieve data from public API, using HTTPClientFactory to work as a client.
- Using: Dependency Injection, Async, implement SOLID
  
 -> Currently output: an API to get a list of categories (no pagination) 

—> Need to be enhanced/implemented: 
- Read all configs such as x-api-key, API endpoint, etc from config env + Keep the API key secure and avoid hardcoding it directly in the code. This way, the API key won't be exposed in case of source code leaks or accidental publishing. +  Can modify config without deploy code
- Error handling: Implement error handling by using custom error to avoid exposing sensitive information in error messages, and return friendly error messages with client-side
- Logging: Implement logging within the application to support in debugging and monitoring the API interactions. Use lib like Serilog
- Object mapping: If the API responses have complex structures, consider using libraries like AutoMapper to map the response data to your domain models.
- Caching if needed: use distributed cache or memory cache
- CROS handling: configure CORS properly to restrict which domains can access the API -> this helps prevent unauthorized access from untrust origins. 
- Validate data received from API matches with our entity, and make sure some error thrown by API response doesn’t block our main thread.
- Can implement rate-limit or bloom filter to prevent attack APIs

###   Front-end:
- Create an HTML page: using jQuery to make an AJAX GET to fetch data from API. If successful, call genderCategories to display as a list (ul-li), otherwise, display an error message.

 —> Currently output: an HTML page load list of categories

—> Need to be enhanced:
 - Error handling: show a friendly message to end users. 
 - Validator: need for case create/update data
