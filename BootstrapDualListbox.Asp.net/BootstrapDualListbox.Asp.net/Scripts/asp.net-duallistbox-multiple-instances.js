function InitDualDropList() {

    $('div.dummy > select').each(function (index, element) {
        $(element).bootstrapDualListbox({
            bootstrap2Compatible: false,
            moveAllLabel: 'MOVE ALL',
            removeAllLabel: 'REMOVE ALL',
            moveSelectedLabel: 'MOVE SELECTED',
            removeSelectedLabel: 'REMOVE SELECTED',
            filterPlaceHolder: 'FILTER',
            filterSelected: '2',
            filterNonSelected: '1',
            moveOnSelect: false,
            preserveSelectionOnMove: 'all',
            helperSelectNamePostfix: '_myhelper',
            selectedListLabel: $($("div.dummy >input[id$='hfselectedListLabel'] ")[index]).val(),
            nonSelectedListLabel: $($("div.dummy >input[id$='hfnonSelectedListLabel'] ")[index]).val(),
            index: index
        })
			.bootstrapDualListbox('setMoveAllLabel', 'Move all teh elementz!!!')
			.bootstrapDualListbox('setRemoveAllLabel', 'Remove them all!')
			.bootstrapDualListbox('setSelectedFilter', undefined)
			.bootstrapDualListbox('setNonSelectedFilter', undefined)
			.bootstrapDualListbox('refresh');
    })


}