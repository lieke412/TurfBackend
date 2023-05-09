<template>
  <div class="bodyDiv">
    <h1>Recepten:</h1>
    <form @submit.prevent="createRecept">
      Add recept
      <input v-model="naam" placeholder="Naam" />
      <input v-model="duur" placeholder="Duur" />
      <input v-model="moeilijkheid" placeholder="Moeilijkheid" />
      <button v-if="naam != ''">Add</button>
    </form>
    <br>
    <div v-for="(recept, index) in recepten" :key="recept.id">
      <div class="tableIndex">
        <div class="insideTable">
          <form v-if="recept.edit" @submit.prevent="updateRecept(recept)" class="formTable">
            <input v-model="recept.naam" placeholder="x" />
            <div class="saveTable">
              <button>Save</button>
            </div>
          </form>
          <p v-else>{{ recept.naam }}, {{ recept.duur }} min, {{ recept.moeilijkheid }}</p>
        </div>
        <div class="divRemove">
          <button @click="removeRecept(recept.id)" v-if="!recept.edit">x</button>
          <button @click="changeLabel(index)" v-if="!recept.edit">Edit</button>
        </div>
      </div>
    </div>
  </div>
</template>
  
<script>
import receptDataService from "@/services/ReceptDataService.js";
//import { ModalPlugin } from "bootstrap-vue";
//import { Modal } from 'usemodal-vue3'

export default {
  name: "ReceptenList",
  data() {
    return {
      recepten: [],
      naam: "",
      modalVisible: false,
    };
  },
  methods: {
    changeLabel(index) {
      this.recepten[index].edit = true;
    },
    updateRecept(recept) {
      receptDataService.updateRecept(recept).then(() => {
        recept.edit = false;
      });
    },
    refreshRecepten() {
      receptDataService.getAllRecepten().then((response) => {
        this.recepten = response.data;
      });
    },
    removeRecept(id) {
      receptDataService.removeRecept(id).then(() => {
        this.refreshRecepten();
      });
    },
    createRecept() {
      receptDataService.createRecept(this.naam, this.duur, this.moeilijkheid).then(() => {
        this.naam = "";
        this.duur = "";
        this.moeilijkheid = "";
        this.refreshRecepten();
      });
    },
  },
  created() {
    this.refreshRecepten();
  }
};
</script>
  
<style></style>
  