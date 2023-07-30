$(document).ready(function () {
 var categoryList = $('#category-list');
 var loadingIndicator = $('#loading-indicator');

 loadingIndicator.show();

 $.ajax({
  url: 'https://localhost:7276/api/categories',
  method: 'GET',
  dataType: 'json',
  success: function (data) {
   // Data retrieved successfully
   loadingIndicator.hide();
   genderCategories(data);
  },
  error: function (_xhr, _status, error) {
   // Handle error
   loadingIndicator.hide();
   console.error('Error fetching data from API:', error);
   categoryList.append('<li>Error: Failed to fetch categories</li>');
  },
 });
});

function genderCategories(categories) {
 var categoryList = $('#category-list');

 // Clear any existing content
 categoryList.empty();

 categories.forEach(function (category) {
  if (category.name && category.name.trim() !== '') {
   var listItem = $('<li>').text(category.name);
   categoryList.append(listItem);
  }
 });
}
