const { ipcRenderer } = window.require('electron')

export async function execute(sql, parameters = []) {
    let teste = await ipcRenderer.invoke('mysql-execute', [sql, parameters])
    console.log(teste)
}

export async function reader(sql, parameters = []) {
    let data = await ipcRenderer.invoke('mysql-reader', [sql, parameters])
    console.log(data)
    return data
}

