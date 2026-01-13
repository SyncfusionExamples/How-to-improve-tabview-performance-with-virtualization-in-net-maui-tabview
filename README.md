# How-to-improve-tabview-performance-with-virtualization-in-net-maui-tabview

A sample application that demonstrates how to enable virtualization in the .NET MAUI TabView. Virtualization ensures that only the selected tab’s content is created initially, and other tabs are loaded on demand, reducing memory usage and improving performance.

## Prerequisites

* Visual Studio 2026 with .NET MAUI workload

## How to run this sample

1. Clone the repository.
2. Open the solution file `TabViewVirtualization.sln` in Visual Studio 2026.
3. Build and run the project.

## Code Snippet

To enable virtualization and bind dynamic content to each tab, use the following code:

```xml
    <ContentPage.BindingContext>
        <local:MainPageViewModel />
    </ContentPage.BindingContext>

    <tabView:SfTabView x:Name="tabView"
                   EnableVirtualization="True"
                   IndicatorPlacement="Fill">

        <tabView:SfTabItem Header="Reports">
            <tabView:SfTabItem.Content>
                <CollectionView ItemsSource="{Binding ReportItems}"
                      VerticalScrollBarVisibility="Always">
                    <CollectionView.ItemTemplate>
                        <DataTemplate>
                            <Grid Padding="12" ColumnDefinitions="*,Auto" BackgroundColor="#FAFAFA" Margin="0,0,0,8">
                                <Label Grid.Column="0" Text="{Binding Title}" FontAttributes="Bold" TextColor="#333"/>
                                <Label Grid.Column="1" Text="{Binding Value}" TextColor="#666"/>
                            </Grid>
                        </DataTemplate>
                    </CollectionView.ItemTemplate>
                </CollectionView>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="Tasks">
            <tabView:SfTabItem.Content>
                 <!-- Add suitable content related to your scenario -->
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="Contacts">
            <tabView:SfTabItem.Content>
                <!-- Add suitable content related to your scenario -->
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView>
```

## Further references

* [EnableVirtualization ](https://help.syncfusion.com/maui/tabview/nested-tabs)

