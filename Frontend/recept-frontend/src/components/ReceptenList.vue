<template>
    <div>
        <h1>Recepten:</h1>
        <div v-for="(recept) in recepten" :key="recept.id">
            <div>
                {{ recept.naam }}
            <button @click="removeRecept(recept.id)">x</button>
            </div>
        </div>

        <form @submit.prevent="createRecept">
            <input v-model="naam"/>
            <button>Add Recept</button>
        </form>
    </div>
</template>

<script>
import receptDataService from "@/services/receptDataService"

export default {
    name: "receptList",

    data() {
        return {
            recepten: [],
            naam:""
        }
    },
    methods: {
        refreshRecepten() {
            receptDataService.getAllRecepten().then((response) => {
                this.recepten = response.data;
            })
        },
        removeRecept(recept) {
            receptDataService.removeRecept(recept).then(window.location.reload().then(this.refreshRecepten))
            
            
        },
        createRecept() {
            receptDataService.createRecept(this.naam).then(window.location.reload().then(this.refreshRecepten))
        }
    },
    created() {
        this.refreshRecepten()
    }
}
</script>

<style></style>