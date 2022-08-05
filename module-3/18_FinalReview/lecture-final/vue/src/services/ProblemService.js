import axios from 'axios';

export default {

  getAllProblems() {
    return axios.get('/api/problems');
  },

  updateProblem(id, updatedProblem) {
    return axios.put('/api/problems/' + id, updatedProblem);
  }
}
