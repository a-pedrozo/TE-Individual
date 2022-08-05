import axios from 'axios';

export default {

getAllProblems(){
  return axios.get('/api/Problems');
}

}
