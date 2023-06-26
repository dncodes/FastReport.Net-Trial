<template>
    <img alt="FR logo" src="./assets/logo.png">
    <ReportsBase msg="Welcome to FastReport.Core.Vue App" />
</template>

<script>
    import ReportsBase from './components/ReportsBase.vue'

    export default {
        name: 'App',
        components: {
            ReportsBase
        },
        created() {
            document.title = "FastReport.Core.Vue";
        }
    }
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 60px;
    }
</style>
