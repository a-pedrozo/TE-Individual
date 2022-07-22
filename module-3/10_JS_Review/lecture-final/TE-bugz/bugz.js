document.addEventListener('DOMContentLoaded', event => {
    console.log("Hello bugz");

    let form = document.querySelector('form');
    console.log('Form', form);

    let bugDesc = document.querySelector('#newBugDescription');
    let bugReportedBy = document.querySelector('#newBugReportedBy');

    console.log(bugDesc, bugReportedBy);

    // Submit occurs when a submit button is clicked, OR the user hits enter in an input box in the form
    form.addEventListener('submit', (event) => {
        let description = bugDesc.value;
        let reporter = bugReportedBy.value;

        // Prevent the form from refreshing the page
        event.preventDefault();

        console.log(description, reporter);

        // At this point we'd save it to a server if we had one

        // Create a TR (table row)
        let tr = document.createElement('tr');

        let tdDesc = document.createElement('td');
        tdDesc.innerText = description;
        tr.appendChild(tdDesc);

        let tdReporter = document.createElement('td');
        tdReporter.innerText = reporter;
        tr.appendChild(tdReporter);

        // Append the TR to the TBody (table body)
        let tbody = document.querySelector('tbody');
        tbody.appendChild(tr);
    });
});