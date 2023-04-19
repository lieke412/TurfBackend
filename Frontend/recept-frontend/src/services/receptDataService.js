import axios from "axios";

class ReceptDataService {
    getAllRecepten() {
        return axios.get("https://localhost:7041/api/Ingredient");
    }
    removeRecept(id){
        return axios.delete(`https://localhost:7041/api/Ingredient/${id}`);
    }
    createRecept(naam){
        const recept ={
            naam: naam
        };
        return axios.post("https://localhost:7041/api/Ingredient", recept)
    }
}

export default new ReceptDataService();