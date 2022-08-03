import Axios from 'axios';

// Create our Axios client (just like RestSharp client)
let axiosOptions = {
    baseURL: 'https://bugslist.azurewebsites.net/' 
}
let client = Axios.create(axiosOptions);
console.log('Client created');

// This is my service object. It handles making REST
// requests to the bug API.
// Other files can import this object.
export default {
    // This is a JavaScript function that other things
    // can call from their components. It will return
    // a promise.
    getAllBugs() {
        return client.get('bugs');
    },
    getBug(bugId) {
        return client.get('bugs/' + bugId);
    },
    deleteBug(bugId) {
        return client.delete(`bugs/${bugId}`);
    },
    addBug(bug) {
        // bug is going to be serialized to
        // JSON and included in the body
        return client.post('bugs', bug);
    },
    updateBug(bug) {
        return client.put('bugs', bug);
    }
}