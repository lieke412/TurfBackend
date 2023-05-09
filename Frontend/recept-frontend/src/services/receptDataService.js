import axios from "axios";

class ReceptDataService {
    getAllRecepten() {
        return axios.get("https://localhost:7041/api/Recept");
    }
    removeRecept(id){
        return axios.delete(`https://localhost:7041/api/Recept/${id}`);
    }
    createRecept(naam, duur, moeilijkheid){
        const recept ={
            naam: naam,
            duur: duur,
            moeilijkheid: moeilijkheid
        };
        return axios.post("https://localhost:7041/api/Recept", recept)
    }
    updateRecept(recept){
        return axios.put("https://localhost:7041/api/Recept", recept)
    }
}

export default new ReceptDataService();