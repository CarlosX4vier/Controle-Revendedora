import { execute, reader } from '../db/DataBase'

export default class CatalogosDAO {
    constructor() { }

    async getCatalogos() {
        const sql = "SELECT * FROM Catalogos";
        const result = await reader(sql)
        return result
    }
}

