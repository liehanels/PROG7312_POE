# PROG7312_POE
This is a brief explanation to download and execute the code and how to use the application.
1.	Clone the repository.
2.	Ensure that the PROG7312_POE.sln file is opened using the Solution Explorer.
3.	Press F5 to compile and run the application.

 PART 1:
1.	Once faced with the Start Up screen, select the first option (Report Issues).
2.	Fill in the fields with the appropriate information taking note of the progress bar.
a.	The progress bar indicates whether enough information has been entered into the respective fields.
b.	To add a picture to your report, click on the button Click to add files. This will open the file explorer in a dialog view.
i.	Images are optional
ii.	Clicking on the image will cycle through all the selected images. 
3.	Click on Submit Form to submit your request.
a.	If any information is outstanding warning messages will inform the user which information should still be included.
4.	Once all the information is corrected and the form can be submitted the user can either view or add a new request.
5.	If yes is selected or the button View Issues is clicked the user will see a list of all the submitted requests.
a.	Clicking on the left square in the Image column will open a form displaying all the images that have been added to the issue.
i.	Clicking on an image will enlarge the image to its native resolution.
ii.	Clicking on the image again will close the image.

 PART 2:
 1. Once faced with the Start-Up screen, select the second option (Events and Announcements).
 2. To use the application, select Add Event first.
 3. Enter the event details.
 i. The time is manually typed in by clicking on the time itself.
 4. Once all the information is input in the fields, select Save event details.
 5. Select return once enough events are added to return to the Events page.
 6. Select Filter Events to display the events based on filters you may prefer and select.
 7. Select the announcements tab and refresh the page by clicking on the Refresh Announcements button.
 8. Select the Recommendations tab to see a list of recommendations based on your filter and search preferences.
 i. If a user has not searched for any events using the filter options on the Events page no recommendations will appear.
 ii. To reset recommendations press the Reset Recommendations button at the bottom of the screen.

PART 3:
Municipal Service Request Application

This C# application visually represents municipal service requests and manages them using a heap data structure for prioritization.

Features

* **Tree Visualization:** Service requests are organized in a tree structure based on location, category, and status.
* **Heap-based Prioritization:** A `SortedSet` (heap) is used to manage and retrieve the highest-priority requests efficiently.
* **Interactive UI:** Users can:
    * View the tree structure in a graphical format.
    * Click on leaf nodes to see detailed information about a request.
    * Add new service requests with a form.

Code Structure

* **`formServiceRequestStatus`:**  The main form class that handles the UI and user interactions.
* **`Tree`:**  Represents the tree structure for organizing requests.
* **`TreeNode`:** Represents a node in the tree.
* **`ServiceRequest`:**  Holds data for a single service request (ID, location, category, status, priority).
* **`ServiceRequestComparer`:**  Implements `IComparer<ServiceRequest>` to define the priority order for the heap.
* **`Prompt`:**  A static class to display a dialog for adding new requests.

How it Works

1. **Initialization:**
   * A `Tree` object is created to represent the service request hierarchy.
   * A `SortedSet<ServiceRequest>` is initialized as a heap using a `ServiceRequestComparer` to prioritize requests.
   * Initial service requests are added to the `SortedSet`.
   * The highest priority request is displayed using `requests.Min`.
   * The tree is populated with the service requests from the `SortedSet`.

2. **Visualization:**
   * A `Panel` control is used to draw the tree structure.
   * The `PaintTree` method handles drawing the tree nodes and connections.
   * The `DrawNode` method recursively draws each node with appropriate colors based on depth.

3. **User Interaction:**
   * Users can click on leaf nodes to view details of a service request.
   * A button allows users to add new requests using the `Prompt` dialog.
   * When a new request is added, it's added to both the `SortedSet` (heap) and the `Tree`.

Priority Scheme

The `ServiceRequestComparer` defines the priority order. In this implementation:

* Lower `Priority` values indicate higher priority.
* Requests are primarily ordered by `Priority`.
* If priorities are equal, the `Id` is used as a tie-breaker.

To Run the Application

Follow the instructions as set above

Further Development

* **Priority Customization:**  Allow users to customize the priority scheme or add more complex priority rules.
* **Data Persistence:** Store service requests in a database or file to preserve data between sessions.
* **Search Functionality:** Implement search capabilities to find specific requests within the tree.
* **UI Enhancements:** Improve the visual presentation and user experience.
