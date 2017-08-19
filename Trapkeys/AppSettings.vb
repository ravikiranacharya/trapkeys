Module AppSettings

    Public _SyncData As Boolean
    Public _StartWithWindows As Boolean
    Public _AlwaysShowInTaskbar As Boolean
    Public _ConfirmToDelete As Boolean
    Public _MaintainHistory As Boolean
    Public _CheckUpdate As Boolean
    Public _DownloadUpdate As Boolean
    Public _UseClipboard As Boolean
    Public _ReportExceptions As Boolean
    Public _NotifyAboutProducts As Boolean
    Public _InstallSampleData As Boolean

    Property SyncData As Boolean
        Get
            Return Form1.ListView2.Items(0).Checked
        End Get
        Set(value As Boolean)
            _SyncData = value
        End Set
    End Property
    Property StartWithWindows As Boolean
        Get
            Return Form1.ListView2.Items(1).Checked
        End Get
        Set(value As Boolean)
            _StartWithWindows = value
        End Set
    End Property
    Property AlwaysShowInTaskbar As Boolean
        Get
            Return Form1.ListView2.Items(2).Checked
        End Get
        Set(value As Boolean)
            _AlwaysShowInTaskbar = value
        End Set
    End Property
    Property ConfirmToDelete As Boolean
        Get
            Return Form1.ListView2.Items(3).Checked
        End Get
        Set(value As Boolean)
            _ConfirmToDelete = value
        End Set
    End Property
    Property MaintainHistory As Boolean
        Get
            Return Form1.ListView2.Items(4).Checked
        End Get
        Set(value As Boolean)
            _MaintainHistory = value
        End Set
    End Property
    Property CheckUpdate As Boolean
        Get
            Return Form1.ListView2.Items(5).Checked
        End Get
        Set(value As Boolean)
            _CheckUpdate = value
        End Set
    End Property
    Property DownloadUpdate As Boolean
        Get
            Return Form1.ListView2.Items(6).Checked
        End Get
        Set(value As Boolean)
            _DownloadUpdate = value
        End Set
    End Property
    Property UseClipboard As Boolean
        Get
            Return Form1.ListView2.Items(7).Checked
        End Get
        Set(value As Boolean)
            _UseClipboard = value
        End Set
    End Property
    Property ReportExceptions As Boolean
        Get
            Return Form1.ListView2.Items(8).Checked
        End Get
        Set(value As Boolean)
            _ReportExceptions = value
        End Set
    End Property
    Property NotifyAboutProducts As Boolean
        Get
            Return Form1.ListView2.Items(9).Checked
        End Get
        Set(value As Boolean)
            _NotifyAboutProducts = value
        End Set
    End Property
    Property InstallSampleData As Boolean
        Get
            Return Form1.ListView2.Items(10).Checked
        End Get
        Set(value As Boolean)
            _InstallSampleData = value
        End Set
    End Property

End Module
